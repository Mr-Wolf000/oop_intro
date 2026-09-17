int[][] sodukuSolved = [
    [5,3,4,6,7,8,9,1,2],
    [6,7,2,1,9,5,3,4,8],
    [1,9,8,3,4,2,5,6,7],
    [8,5,9,7,6,1,4,2,3],
    [4,2,6,8,5,3,7,9,1],
    [7,1,3,9,2,4,8,5,6],
    [9,6,1,5,3,7,2,8,4],
    [2,8,7,4,1,9,6,3,5],
    [3,4,5,2,8,6,1,7,9],
];

bool validSolve = true;

// checks the horisontal line
foreach (int[] line in sodukuSolved) {
    for (int i = 0 ; i<sodukuSolved.Length ; i++) {
        for (int j = i+1 ; j<sodukuSolved.Length ; j++) {
            if (line[i]==line[j]) {
                validSolve = false;
                Console.WriteLine("Solve is not valid on one of the horisontal lines");
                break;
            }
        }
    }
}

for (int x = 0 ; x<sodukuSolved[0].Length ; x++) {
    for (int y = 0 ; y<sodukuSolved.Length ; y++) {
        for (int z = y+1 ; z<sodukuSolved.Length ; z++) {
            if (sodukuSolved[y][x]==sodukuSolved[z][x]) {
                validSolve = false;
                Console.WriteLine("Solve is not valid on one of the vertical lines");
                break;
            }
        }
    }
}

Console.WriteLine(validSolve);