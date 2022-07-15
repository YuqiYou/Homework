

//7.14 class

//4 ways to create the object in JS
//object literals
var Person = {firstName:"A", lastName:"Yuqi", Age:22, Location:"Washington"};
console.log(Person);

//Function constructors
function guy(first="default", last="default",Age, Location){
    this.firstName = first;
    this.lastName = last;
    this.Age = Age;
    this.Location = Location;

}



const Karim = new guy("Karim", "LIn", 22, "washington");
console.log(karim);


//object.create method
const newPerson = Object.create(karim);
console.log(newPerson);
newPerson.firstName = "F";
newPerson.lastName = "L";
newPerson.Age = 12;
newPerson.Location = "worting";


//Class
class Car{
    constructor(Make,Model){
        this.Make= Make;
        this.Model=Model;
    }

    intro(){
        console.log(this.Make,this.Model);
    }
}


const newCar = new Car("ford", "focus");
console.log(newCar);
newCar.intro();


//inheritance
class Engine extends Car{
    constructor(Make, Model, Engine){
        super(Make,Model);
        this.Engine = Engine;
    }
}

const SCar = new Engine("ford", "mu","VC");
console.log(sCar);


let Salaries = {
    John:100,
    Ann:160,
    Pete:130
};

var sum = Salaries.John+Salaries.Ann+Salaries.Pete;
console.log(sum);

const SalaryArray = [100,160,130];
console.log(SalaryArray);
console.log(SalaryArray[1]);


//change value of array item
salariesArray[1] = 200;


//Add item to array
salariesArray.push(4444);


//Remvoe last item from array
//Last in First out
salariesArray.pop();



//remove first item from array
salariesArray.shift();


//remove item 
salariesArray.push(100,200,300,400,500,600);

//start from element 3 and cut out 2 elements
salariesArray.splice(3,2);


//function 
function functionName(){
    for(var i = 0; i < salariesArray.length;i++){
        salariesArray[i]+= 1;
    }
}

//function execution

functionName();

//iterator through every element in an object
for(let elememt in object){

}
