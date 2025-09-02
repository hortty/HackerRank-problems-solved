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

function getLetter(s) {
    let letter;
    // Write your code here
    letter = s.split("");
    switch(letter[0])
    {
        case 'a' || 'e' || 'i' || 'o' || 'u':
            return 'A';
        case 'b' || 'c' || 'd' || 'f' || 'g':
            return 'B';
        case 'h' || 'j' || 'k' || 'l' || 'm':
            return 'C';
        default:
            return 'D';    
    }
}


function main() {
    const s = readLine();
    
    console.log(getLetter(s));
}