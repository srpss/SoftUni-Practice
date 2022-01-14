//https://softuni.bg/trainings/resources/officedocument/68120/dokument-exercise-js-advanced-january-2022/3588

//console.log(_1_(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']))

// console.log(_2_({ weight: 80,
//     experience: 1,
//     levelOfHydrated: 0,
//     dizziness: true }))

// console.log(_3_({ model: 'Opel Vectra',
// power: 110,
// color: 'grey',
// carriage: 'coupe',
// wheelsize: 17 }))
    

// console.log(_4_(['Isacc / 25 / Apple, GravityGun',
// 'Derek / 12 / BarrelVest, DestructionSword',
// 'Hes / 1 / Desolator, Sentinel, Antara']))

// console.log(_5_(['Sample Town | Sample Product | 1000',
// 'Sample Town | Orange | 2',
// 'Sample Town | Peach | 1',
// 'Sofia | Orange | 3',
// 'Sofia | Peach | 2',
// 'New York | Sample Product | 1000.1',
// 'New York | Burger | 10']))

// console.log(_6_([
// 'Appricot : 20.4',
// 'Fridge : 1500',
// 'TV : 1499',
// 'Deodorant : 10',
// 'Boiler : 300',
// 'Apple : 1.25',
// 'Anti-Bug Spray : 15',
// 'T-Shirt : 10']
// ))

// console.log(_7_(['| Town | Latitude | Longitude |',
// '| Sofia | 42.696552 | 23.32601 |',
// '| Beijing | 39.913818 | 116.363625 |']
// ))

//_8_  
// let rect = rectangle(4, 5, 'red');
// console.log(rect.width);
// console.log(rect.height);
// console.log(rect.color);
// console.log(rect.calcArea());


let create = solve();
const scorcher = create.mage("Scorcher");
scorcher.cast("fireball")
scorcher.cast("thunder")
scorcher.cast("light")

const scorcher2 = create.fighter("Scorcher 2");
scorcher2.fight()

console.log(scorcher2.stamina);
console.log(scorcher.mana);


function solve(){    
    let canCast = (state) =>({
        cast: (spell) => {
            console.log(`${state.name} cast ${spell}`)
            state.mana--;
        }
    })
    let canFight = (state) =>({
        fight: () => {
            console.log(`${state.name} slashes at the foe!`)
            state.stamina--;
        }
    })
    let mage = (name) => {
        let state ={
            name,
            health: 100,
            stamina: 100
        }
        return Object.assign(state, canCast(state))
  }

  let fighter= (name) => {
    let state ={
        name,
        health: 100,
        stamina: 100
    }
    return Object.assign(state, canFight(state))
   }

   return {mage: mage, fighter: fighter}
}
    



function rectangle(w, h, c){
    e = c.charAt(0).toUpperCase() + c.slice(1)
    let obj = {
        width: w,
        height: h,
        color: e,
        calcArea() {
              return obj.width * obj.height;
        }
    }
    return obj
}




function _7_(arr= []){
   let array= arr[0].split(/[|]/);
   let town = array[1].trim();
   let lett = array[2].trim();
   let lutt = array[3].trim();
   arr.shift();
   let arrobj = [];
   for (let i = 0; i < arr.length; i++) {
    let array1= arr[i].split(/[|]/);
       let obj = {}
       obj[town] =array1[1].trim();
    
       obj[lett.trim()] = Number((Number(array1[2])).toFixed(2));
       obj[lutt.trim()] = Number((Number(array1[3])).toFixed(2));
       arrobj.push(obj);
   }
   let arrobjJSON = JSON.stringify(arrobj);
   return arrobjJSON;
}




function _6_(arr= []){
    objarr = {};
    arr.forEach((el) => {
        let [name, price] = el.split(' : ');
        if (!objarr[name[0]]) {
            objarr[name[0]] = {};
        }
        objarr[name[0]][name] = price;
    })
    let initalSort = Object.keys(objarr).sort((a,b)=>a.localeCompare(b))
    for (const prod of initalSort) {
        let sorted = Object.entries(objarr[prod]).sort((a, b) => a[0].localeCompare(b[0]));
        console.log(prod)
        sorted.forEach((el) =>{
            console.log(`  ${el[0]}: ${el[1]}`)       
        })        
    }
}


function _5_(arr= []){
    let objarr = {}
    arr.forEach((el) => {
    
    let [town,product,price] = el.split(" | ");
    price = Number (price);
    if (!objarr[product]) {
        objarr[product]={};
    }
    objarr[product][town] = price;
    });
   
    for (const prod in objarr) {
        const sorted = Object.entries(objarr[prod]).sort((a, b) => a[1] - b[1]);
        console.log(`${prod} -> ${sorted[0][1]} (${sorted[0][0]})`)

    }
}
    

 



function _4_(arr = []){
    
    let objarr = []
    for (const i of arr) {
        obj = {};
        let splited = i.split(" / ")
        
        obj["name"] = splited[0];
        obj["level"] = Number (splited[1]);
        if (splited.length == 3) {
            let items = splited[2].split(", ");
            obj["items"] = items;
        } else {
            obj["items"] = [];
        }
        
        objarr.push(obj);
        
    }
    let jsoned = JSON.stringify(objarr);
    return jsoned;
    }

    

function _3_(arr){
    obj = {};
    obj['model'] = arr.model;
    let v = 0;
    if (arr.power <= 90) {
        arr.power = 90;
        v = 1800;
    }else if (arr.power <= 120) {
        arr.power = 120;
        v = 2400 ; 
    }else if (arr.power > 120) {
        arr.power = 200;
        v = 3500 ;
    }
    obj['engine'] = {'power': arr.power, 'volume': v};
    obj['carriage'] = {'type': arr.carriage, 'color': arr.color};
    if (arr.wheelsize % 2 != 1) {
        arr.wheelsize = Math.floor(arr.wheelsize);
        if (arr.wheelsize % 2 != 1) {
            arr.wheelsize --;
        }
    }
    
    obj['wheels'] = [arr.wheelsize, arr.wheelsize, arr.wheelsize, arr.wheelsize]
    return obj;
}


function _2_(arr){
   if (arr.dizziness == true) {
       arr.levelOfHydrated += (arr.experience / 10) * arr.weight;
   }
    return arr
}


function _1_(arr){
   let rt = {};
   for (let i = 0; i < arr.length- 1; i+= 2) {
       
       rt[arr[i]] = Number(arr[i+1]) ;
   }
    let str = `{ `;
   for (const key in rt) {
       str += `${key}: ${rt[key]}, `
   }
   str = str.slice(0 , str.length- 2);
   str+= ` }`;
   console.log(str);
}







 
function compare( a, b ) {
    if ( a.productName < b.productName ){
      return -1;
    }
    if ( a.productName > b.productName ){
      return 1;
    }
    if ( a.productPrice < b.productPrice ){
        return -1;
      }
      if ( a.productPrice > b.productPrice ){
        return 1;
      }
    return 0;
  }
  