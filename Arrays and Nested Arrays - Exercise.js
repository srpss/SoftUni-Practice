//https://softuni.bg/trainings/resources/officedocument/68117/dokument-exercise-js-advanced-january-2022/3588

// console.log(_1_(['One', 
// 'Two', 
// 'Three', 
// 'Four', 
// 'Five'], 
// '-'
// ))

// console.log(_2_(['5', 
// '20', 
// '31', 
// '4', 
// '20'], 
// 2
// ))

// console.log(_3_(['add', 
// 'add', 
// 'remove', 
// 'add', 
// 'add']
// ))

// console.log(_4_(['1', 
// '2', 
// '3', 
// '4'], 
// 2
// ))

// console.log(_5_([1, 
//     3, 
//     8, 
//     4, 
//     10, 
//     12, 
//     3, 
//     2, 
//     24]    
// ))

//console.log(_6_(["John", "Bob", "Christina", "Ema"]  ))

//console.log(_7_([1, 65, 3, 52, 48, 63, 31, -3, 18, 56, 10]))

//console.log(_8_(['alpha', 'beta', 'gamma']))         
//not finished

// console.log(_9_([[4, 5, 6],
//     [6, 5, 4],
//     [5, 5, 5]]
//    ))
//not finished

function _9_(arr= [[]]){
    let checker =true;
    for (const i of arr) {

        let col = 0;
        for (let b = 0; b < i.length; b++) {
            col += i[b];            
        }
        for (const y of i) {
            let row = 0;
            for (let c = 0; c < y.length; c++) {
                row += y[c];
                
            }
            if (col != row) {
                checker = false;
                break;
            }
            if (checker == false) {
                break;
            }
        }
        if (checker == false) {
            break;
        }
    }
    return checker;
}


function _8_(arr= []){
    arr = arr.sort((a, b) => a.length - b.length )
    for (const i    of arr) {
        console.log(i);
    }
}

function _7_(arr= []){
    let small = Array.from(arr).sort((a,b)=> a-b);
    let big = Array.from(arr).sort((a,b)=> b - a);
    let newarr = [];
    for (let i = 0; i < small.length/2; i++) {
        newarr.push(small[i]);
        newarr.push(big[i]);
        
    }
    if (arr.length % 2 != 0) {
        newarr.pop();
    }
    return newarr;
}


function _6_(arr= []){
    arr = arr.sort();
    let counter = 1;
    for (const i of arr) {
        console.log(`${counter}.${i}`)
        counter++;
    }
}


function _5_(arr= []){
    let big = Number.MIN_VALUE;
    let newArr = [];
    newArr.push(arr[0]);
    for (let i = 1; i < arr.length; i++) {
        if (newArr[newArr.length - 1] <= arr[i]) {
            newArr.push(arr[i]);
        }
    }
    return newArr;
}

function _4_(arr= [], sym){
for (let i = 0; i < sym; i++) {
    arr.unshift(arr.pop());    
}
console.log(arr.join(' '));
}

function _3_(arr){
    let str = [];
    let counter = 1;
for (const i of arr) {
    if (i === 'add') {
        str.push(counter);
        counter ++;
    } else if (i === 'remove'){
        str.pop();
        counter++;
    }
   
}
if (str.length === 0) {
    console.log('Empty')
} else{
    for (const i of str) {
        console.log(i);
    }
}
}

function _2_(arr, sym){
    let str = [];
    str.push(arr[0]);
    let counter = 0;
for (const i of arr) {
    if (counter === sym) {
        str.push(i);
        counter = 0;
    }
    counter++;
}
return str
}

function _1_(arr, sym){
    let str = '';
for (const i of arr) {
    str += i + sym;
}
str = str.slice(0, str.length - 1);
return str
}