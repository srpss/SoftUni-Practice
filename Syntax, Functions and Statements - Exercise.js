// https://softuni.bg/trainings/resources/officedocument/68114/dokument-exercise-js-advanced-january-2022/3588
//_1_('orange', 2500, 1.80)
//console.log(_2_(15,5))
//console.log(_3_(2222222))
//console.log(_4_(2016, 10, 1))
//console.log(_6_(120,'interstate'))
//console.log(_7_('9', 'dice', 'spice', 'chop', 'bake', 'fillet'))
console.log(_8_(2, 1, 1, 1))

function _1_(...fruit){
console.log(`I need $${((fruit[1]/1000) * fruit[2]).toFixed(2)} to buy ${(fruit[1]/1000).toFixed(2)} kilograms ${fruit[0]}.`);
}
function _2_(...num){
    let y = num[1];
    let x = num[0];
    while(y) {
        var t = y;
        y = x % y;
        x = t;
      }
      return x;
    }

    function _3_(num){
        let t = String (num)
        let arr = t.split('');
        arr = arr.map(n => Number(n))
        let next = arr[1];
        let bo = true;
        for (let i = 0; i < arr.length - 1; i++) {
          for (let j = i; j < arr.length - 1; j++) {
            if (arr[j] !== next) {
              bo = false
              break;
            }
            next = arr[j + 1]  
          }             
        }
        let sum = arr.reduce(function (a, b) {
          return a + b;
        }, 0);        
        console.log(`${bo}\n${sum}`)
    }
    function _4_(year, mon, day){
       let date = new Date(year, mon, day)
      date.setDate(date.getDate()-1);
       console.log(`${date.getFullYear()}-${date.getMonth()}-${date.getDate()}`)
    }
    function _5_(steps, len, km){
      meters = steps * len;//2400
      h = km * 1000;//5000
      total = Math.abs(meters - h);//2600

   }
   function _6_(km, where){
    //  On the motorway, the limit is 130 km/h
    //  On the interstate, the limit is 90 km/h
    //  In the city, the limit is 50 km/h
    //  Within a residential area, the limit is 20 km/h
    let limit = 0;
    if (where =='motorway') {
      limit = 130;
    }
    else if (where =='interstate') {
      limit = 90;
    }
    else if (where =='city') {
      limit = 50;
    }
    else if (where =='residential') {
      limit = 20;
    }
    if (km <= limit) {
      console.log(`Driving ${km} km/h in a ${limit} zone`);
      
    }
    else{
      let status = '';
      if (Math.abs(km - limit) <=20) {
        status = 'speeding'
      }
      else if (Math.abs(km - limit) <=40) {
        status = 'excessive speeding'
      }
      else {
        status = 'reckless driving'
      }
      console.log(`The speed is ${Math.abs(km - limit)} km/h faster than the allowed speed of ${limit} - ${status}`)
    }

 }

//  •	chop - divide the number by two
// •	dice - square root of a number
// •	spice - add 1 to the number
// •	bake - multiply number by 3
// •	fillet - subtract 20% from the number

 function _7_(num, ...arr){
   num = Number (num);
  let theSwitcher = {
    chop(){num = num / 2;},
    dice(){num = Math.sqrt(num);},
    spice(){num++;},
    bake(){num*=3;},
    fillet(){num -= num*20/100;}
    
  }
  for (const i of arr) {
    theSwitcher[i]();
    console.log(num)
  }
  
}

function _8_(num, ...arr){
  num = Number (num);
 let theSwitcher = {
   chop(){num = num / 2;},
   dice(){num = Math.sqrt(num);},
   spice(){num++;},
   bake(){num*=3;},
   fillet(){num -= num*20/100;}
   
 }
 for (const i of arr) {
   theSwitcher[i]();
   console.log(num)
 }
 
}