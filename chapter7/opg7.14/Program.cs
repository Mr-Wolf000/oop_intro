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
            if (line[i]==line[j]) { // Case where the answer is invalid
                validSolve = false;
                Console.WriteLine("Solve is not valid on one of the horisontal lines");
                break;
            }
        }
    }
}
// checks the vertical lines
for (int x = 0 ; x<sodukuSolved[0].Length ; x++) {
    for (int y = 0 ; y<sodukuSolved.Length ; y++) {
        for (int z = y+1 ; z<sodukuSolved.Length ; z++) {
            if (sodukuSolved[y][x]==sodukuSolved[z][x]) { // Case where the answer is invalid
                validSolve = false;
                Console.WriteLine("Solve is not valid on one of the vertical lines");
                break;
            }
        }
    }
}

int grid = 3;

// loop that makes a new array box[] that holds the values of int's in each 3x3 grid.
for (int i = 0 ; i<sodukuSolved.Length/grid ; i++) { // desides the start row of box
    for (int j = 0 ; j<sodukuSolved.Length/grid ; j++) { // desides the start collum of box
        int[] box = new int[(grid*grid)]
        int boxIndex = 0;
        for (int x = 0 ; x<grid ; x++) { // row number in grid/box
            for (int y = 0 ; y<grid ; y++) { // collum number in grid/box
                box[boxIndex] = sodukuSolved[i*3+x][j*3+y];
                boxIndex++;
            }
        }

        // When the box of 3x3 as a 1D array of length 9 checks if there are any doublicates.
        for (int a = 0 ; a < box.Length ; a++) {
            for (int b = a+1 ; b < box.Length ; b++) {
                if (box[a]==box[b]) {
                    validSolve = false;
                    Console.WriteLine("Box is invalid at box row: {0} collum: {1}", i, j);
                    break;
                }
            }
        }
    }
}

Console.WriteLine("The soduku answer is: {0}", validSolve);