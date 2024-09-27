let taskCounter = 1;
function addTask() {
    let div = document.createElement('div');

   

    div.innerHTML = taskCounter + '. ' +
        document.getElementById('newTask').value;

    document.getElementById('newTask').value = '';

    div.className = 'task';
    document.body.append(div);
    taskCounter++;
}