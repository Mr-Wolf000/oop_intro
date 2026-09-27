int[] grades = [4,7,2,0,10,4,12];
Exception fail = new Exception("Coures not passed");
int getGrade (int couresid) {
    int grade = grades[couresid];
    if (2<=grade) {
        return grade;
    } else {
        throw fail;
    }
}

int count = 0;
int sum = 0;

for (int courseid = 0 ; courseid<grades.Length ; courseid++) {
    try {
        sum += getGrade(courseid);
        count++;
    } catch (Exception) {
        
    }
}
Console.WriteLine((double)sum/(double)count);