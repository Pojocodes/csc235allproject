#include <stdio.h>
#include <stdbool.h>



int noOfOccurence (int num, int digit){
    int count = 0;
    while (num>0){
        {
            if (num % 10 == digit) {
                count ++;
            }
            num = num/10;
        }
    }
    return count;
}

int getNumDigit (long num) {
    int digits = 0;
    while(num > 0){
        num = num/10;
        digits++;
    }
    return digits;
}

int main() {
    int start = 0;
    FILE *fh_input;
    fh_input = fopen("self.txt","r");
    int finput;
    while(fscanf(fh_input, " %d ", &finput)!= EOF){
        //printf("%d",finput);
        int temp = finput;
        
        int x = true;
        int noofdigit = getNumDigit(temp) - 1;
        while(temp>0){
            int digit = temp % 10;
            int count = noOfOccurence(finput,noofdigit);
            if (count != digit){
                printf("Not self-describing\n");
                x = false;
                break;
            }
            
            temp = temp/10;
            noofdigit--;
        }
        if (x) {
            printf("Self-describing\n");
        }
        
            
        
    }
    return 0;
}


















