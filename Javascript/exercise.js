//PROBLEM 1
let salaries = {John: 100,Ann: 160,Pete: 130};

let sum = salaries.John+salaries.Ann+salaries.Pete;
console.log("The sum is" + sum);


//PROBLEM 2

let menu = {width: 200,height: 300,title: "My menu"};

function multiplyNumeric(obj) {
    for (let key in obj) {
      if (typeof obj[key] == 'number') {
        obj[key] *= 2;
      }
    }
  }

  multiplyNumeric(menu);
  console.log(menu);


//PROBLEM 3

function checkEmailid(str){
  for(var i = 0; i < str.length; i++){
    if(str.charAt(i)=='.'){
      if(str.charAt(i+1)=='@')
      return true;
    }
    return false;
  }
}

//PROBLEM 4

function truncate(str,maxlength){
  var result = "";
  for(var i = 0; i < maxlength;i++){
    result+=str.charAt(i);
  }
  return result;
}

//PROBLEM 5
const arr = ["James","Brennie"];

arr.push("Robert");
arr[1] = "Calvin";

arr.shift();

const arr2 = ["Rose", "Regal"];
arr2.concat(arr);
