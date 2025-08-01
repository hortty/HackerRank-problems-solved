'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

/*
 * Complete the vowelsAndConsonants function.
 * Print your output using 'console.log()'.
 */
function vowelsAndConsonants(s) {
    [...s].forEach(letter => {
        if(isVowel(letter))
        {
           console.log(letter);
        }
    });
    [...s].forEach(letter => {
        if(!isVowel(letter))
        {
           console.log(letter);
        }
    });
    // forEach(letter in s)
    // {
    //     if(!isVowel(letter))
    //     {
    //        console.log(letter);
    //     }
    // }
}

function isVowel(letter)
{
    return letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u';
}


function main() {
    const s = readLine();
    
    vowelsAndConsonants(s);
}