package com.tcc.transportadora;

import android.app.Activity;
import android.os.Bundle;

import android.content.Intent;

import android.view.MotionEvent;

public class SplashActivity extends Activity {
	
	private Thread mSplashThread; 
    private boolean mblnClicou = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_splash);
        
        mSplashThread = new Thread() {
            @Override
            public void run() {
             try {
                    synchronized(this){
                        //Espera por 5 segundos or sai quando
                     //o usu�rio tocar na tela
                        wait(5000);
                        mblnClicou = true;
                    }
                }
                catch(InterruptedException ex){                    
                }
                 
                if (mblnClicou){
                 //fechar a tela de Splash
                    finish();
                     
                 //Carrega a Activity Principal
                 Intent i = new Intent();
                 i.setClass(SplashActivity.this, MainActivity.class);
                 startActivity(i);
                }
            }
        };
         
        mSplashThread.start();
    }
     
    @Override
    public void onPause()
    {
        super.onPause();
         
        //garante que quando o usu�rio clicar no bot�o
        //"Voltar" o sistema deve finalizar a thread
        mSplashThread.interrupt();
    }
     
    @Override
    public boolean onTouchEvent(MotionEvent event) {
        if (event.getAction() == MotionEvent.ACTION_DOWN) {
            //o m�todo abaixo est� relacionado a thread de splash
         synchronized(mSplashThread){
          mblnClicou = true;
           
             //o m�todo abaixo finaliza o comando wait
             //mesmo que ele n�o tenha terminado sua espera
                mSplashThread.notifyAll();
            }            
        }
        return true;
    }
 
}
