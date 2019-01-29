function mathCalc() {
    var pattern = /-?\d+(\.\d+)?|[\/\+\-\=\*]{1}/g;
    var numb = document.getElementById("text1").value;
    var arr = numb.match(pattern);
    var result;
    if (+arr[0] !== "NaN") {
        result = +arr[0];
    }
    for (let i = 0; i < arr.length; i++) {
        switch (arr[i]) {
            case '+':
                result += +arr[i + 1];
                break;

            case '*':
                result *= arr[i + 1];
                break;

            case '/':
                result /= arr[i + 1];
                break;
            case '=':
                document.getElementById('text2').value = result.toFixed(2);
                break;
        }
        if (arr[i] < 0 && arr[i - 1] != '*' && arr[i - 1] != '/' && arr[i - 1] != null) {
            result += +arr[i];
        }
    }
}