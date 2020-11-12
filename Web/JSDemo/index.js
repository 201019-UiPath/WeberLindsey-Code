function BasicFunction() {
    alert("Hello World of JS!");
}

function ParentFunction(callBack) {
    console.log("In parent function");
    let name = prompt("Please enter your name: ");
    callBack(name);
    console.log('Back in parent function');
}

function CallBack(name) {
    console.log(`Hello, ${name}`);
    console.log('Calling back');
}

function Outer() {
    let count = 0;
    let result = function inner(count) {
        return ++count;
    }
    console.log(result(count));
    
}