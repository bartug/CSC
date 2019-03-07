#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h> 
#define BOYUT 5
  
int stack[BOYUT - 1];
int top = -1;
 
void push(int item)
{        
    if(top+1 != BOYUT)
    {
        top = top + 1;
        stack[top] = item;
    }
    else
    {
        printf("\nStack Dolu");
    }
}
void pop()
{       
    if(top != -1)
    {  
        top = top - 1;
    }
    else
    {
        printf("\n Cikarcak Eleman Yok");
    }
}
 
void display()
{
    int i;   
    for( i = 0; i < top + 1; i++)
    {
        printf("%d- ", stack[i]);
    }
}
int main()
{
    int item;
    int a;
    display();
    printf("\n");
    push(5);
	display();
    printf("\n");push(7);
    display();
    printf("\n");
    push(11);
    display();
    printf("\n");
    pop();
    display();
    printf("\n");
    
    
}
