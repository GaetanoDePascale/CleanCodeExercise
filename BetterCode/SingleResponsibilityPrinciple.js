// Better Code
function validateData(data) {
    // validate data stuff
}
function saveData(data) {
    // save data to database code
}
function sendData(data) {
    // send data to another system operation
}

function logData(data) {
    // log data	
}

function finalizeOperation() {
    // redirect 
}

function saveUserData(data) {
    validateData(data);
    saveData(data);
    sendData(data);
    logData(data);
    finalizeOperation();
}