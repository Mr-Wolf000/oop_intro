int dice = 4;
bool dice_thing;
if (dice>=3 && dice%2==0) {
    dice_thing = true;
}
else {
    dice_thing = false;
}
Console.WriteLine(dice_thing);