//Clifford Johnson
//Project Onboarding Coding Challenge
//Week of March 7th, 2022

function getItemsAt(arr, par){
    const smallerArray = [];
    var parMatch;
    const outPutArray = [];

    //Fill the Smaller Array with all elements from the original Array except index 0 and 1
    for(let i = 0; i < arr.length; i++){
        if (i != 0 && i != 1){
            smallerArray.push(arr[i]);
        }
    }

    //Adds the 1st or 2nd element of the Array to the output depending on the array length and parity
    if (par == 'even'){//Determines Parity
        if(arr.length % 2 == 0){//Determines if the array is even or odd in length
            outPutArray.push(arr[0]);
        }
        else {
            outPutArray.push(arr[1])
        }
    }
    else if (par == 'odd'){
        if (arr.length % 2 == 0){
            outPutArray.push(arr[1]);
        }
        else {
            outPutArray.push(arr[0]);
        }
    }

    //Make another recursive call as long as the array is at least 3 elements long
    if (arr.length > 2){
        parMatch = getItemsAt(smallerArray, par);
        outPutArray.push(parMatch);
    }

    //Return the parity-specified elements
    return outPutArray;
}

//Console Output for Testing
const printTestArray1 = getItemsAt([2, 4, 6, 8, 10], "odd");
console.log("Test Array 1: " + printTestArray1);
const printTestArray2 = getItemsAt(["E", "D", "A", "B", "I", "T"], "even");
console.log("Test Array 2: " + printTestArray2);
const printTestArray3 = getItemsAt([")", "(", "*", "&", "^", "%", "$", "#", "@", "!"], "even");
console.log("Test Array 3: " + printTestArray3);
const printTestArray4 = getItemsAt(["A", "R", "B", "I", "T", "R", "A", "R", "I", "L", "Y"], "even");
console.log("Test Array 4: " + printTestArray4);