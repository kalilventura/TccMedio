// mascara dd e telefone
function mascara(o, f) {
    v_obj = o
    v_fun = f
    setTimeout("execmascara()", 1)
}
function execmascara() {
    v_obj.value = v_fun(v_obj.value)
}
function mtel(v) {
    v = v.replace(/\D/g, "");             //Remove tudo o que não é dígito
    v = v.replace(/(\d)(\d{4})$/, "$1-$2");    //Coloca hífen entre o quarto e o quinto dígitos
    return v;
}
function ddtel(d) {
    d = d.replace(/\D/g, "");             //Remove tudo o que não é dígito
    d = d.replace(/^(\d{2})/g, "($1)"); //Coloca parênteses em volta dos dois primeiros dígitos
    return d;
}
function id(el) {
    return document.getElementById(el);
}
