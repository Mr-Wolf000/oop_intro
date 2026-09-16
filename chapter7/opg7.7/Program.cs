int[][] soduku_h = [
    [1,2,3,4,5,6,7,8,9],
    [2,3,4,5,6,7,8,9,1],
    [3,4,5,6,7,8,9,1,2],
    [4,5,6,7,8,9,1,2,3],
    [5,6,7,8,9,1,2,3,4],
    [6,7,8,9,1,2,3,4,5],
    [7,8,9,1,2,3,4,5,6],
    [8,9,1,2,3,4,5,6,7],
    [9,1,2,3,4,5,6,7,8],
];
// does not work...
// int[][] soduku_s = new int[9][9];

foreach (int[] line in soduku_h) {
    foreach (int num in line) {
        Console.Write(num+" ");
    }
    Console.WriteLine("");
}