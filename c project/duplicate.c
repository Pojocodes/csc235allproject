#include<stdio.h>
#include<stdbool.h>
#include<string.h>

//a function to sort an array
void sortedArr(int arr[],size_t n) {
    for( int i = 0;i < n; ++i ){
        for (int j = i + 1; j < n; ++j){
            if (arr[i] > arr[j]) {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

}

// the main function
int main() {
    FILE *fh_input;
    fh_input = fopen("files.txt","r");
    int filebegin;
    char buff[10];
    if(fh_input != NULL){
        fgets(buff,10,fh_input);
        while(fscanf(fh_input, "%d", &filebegin) != EOF) {
            int index = filebegin -1 +2;
            int arrnum[index]; 
            char temp[index][100];
            int comp;
            int max=0;
            int mid = 100000;
            int len2 = sizeof(temp)/sizeof(temp[1]);
            for (int i = 0; i < filebegin; i++){
                char buffer[100];
                int num;
                fscanf(fh_input,"%s %d", buffer, &comp);
                int min = arrnum[0];
                if(max<comp) {
                    max = comp;
                }
                if (mid > comp){
                mid = comp;
                }
                for (int k = 0; k < len2; k++) {

                    if(!strcmp(buffer,temp[k])){
                        if (min < comp){
                        arrnum[k] = min;
                        }
                        break;
                    }
                    else {
                        if(strlen(temp[k]) == 0){
                            arrnum[k] = comp;
                            strcpy(temp[k],buffer);
                            break;
                        }
                    }   
                }   
            }

            size_t len = sizeof(arrnum)/sizeof(arrnum[1]);
            sortedArr(arrnum,len);
            for (int j = 0; j<len-1; j++) {
                if((arrnum[j] > mid-1) && (arrnum[j]<max+1)){
                    printf("%d ", arrnum[j]);
                }
            
            }
            printf("\n");

            printf("----------\n");


        }
    }
    
    fclose(fh_input);
    return 0;
}
