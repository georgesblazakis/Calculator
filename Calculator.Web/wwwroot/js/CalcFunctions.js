const uri = 'http://localhost:5000/api/CalculatorFunctions';

var firstOperand = null;
var operator = null;
var waitForSecondNumber = false;

function getNumber(number){
    console.log(number);
    //second number
    if (this.waitForSecondNumber) {
        document.getElementById('valueScreen').value = number;
        this.waitForSecondNumber = false;
    } else {
        //first number
        document.getElementById('valueScreen').value === '0' ? document.getElementById('valueScreen').value = number : document.getElementById('valueScreen').value += number;
    }
}

function getDecimal(){
    if (!document.getElementById('valueScreen').value.includes('.')) {
        document.getElementById('valueScreen').value += '.';
    }
}

function getOperation(op){
    console.log(op);

    if (firstOperand == null) {
        this.firstOperand = parseFloat(document.getElementById('valueScreen').value);
        console.log("firstOperand null");
    } else if (this.operator) {
        console.log(operator)
        const result = this.doCalculation(this.operator, parseFloat(document.getElementById('valueScreen').value))
        //document.getElementById('valueScreen').value = result.toString();
        //this.firstOperand = result;
    }
    this.operator = op;
    this.waitForSecondNumber = true;

    //console.log(this.firstOperand);
}


function doCalculation(op, secondOp) {
    console.log(op, secondOp);
    switch (op) {
        case '+':
            return callAPICalcFunctions(`/Sum?` + new URLSearchParams({ number1: firstOperand, number2: secondOp }) );
        case '-':
            return callAPICalcFunctions(`/Sub?` + new URLSearchParams({ number1: firstOperand, number2: secondOp }));;
        case '*':
            return callAPICalcFunctions(`/Mult?` + new URLSearchParams({ number1: firstOperand, number2: secondOp }));;
        case '/':
            return callAPICalcFunctions(`/Div?` + new URLSearchParams({ number1: firstOperand, number2: secondOp }));;
        case '=':
            return secondOp;
    }
}

function cleanScreen() {
    console.log("ac");
    document.getElementById('valueScreen').value = '0';
    this.firstOperand = null;
    this.operator = null;
    this.waitForSecondNumber = false;
    this.APINumber1 = 0;
    this.APINumber2 = 0;
}


function callAPICalcFunctions(operator) {
    document.getElementById('load').className = "loading"
    document.getElementById('content').style.backgroundColor = 'lightgrey';

    fetch(`${uri}${operator}`, {
        method: 'POST',
    })
    .then((response) => response.json())
    .then((responseData) => {
        console.log(responseData);
        document.getElementById('valueScreen').value = responseData.toString();
        this.firstOperand = responseData;
        document.getElementById('load').className = "none"
        document.getElementById('content').style.backgroundColor = '';

        return responseData;
    })
    .catch(error => document.getElementById('valueScreen').value = "Error");
}
