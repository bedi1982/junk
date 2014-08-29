package View;

public class Main {
	public static void main(String[] args) {
		
		String en = "incomodam";
		int i = 1;
		int y = 0;

		
		System.out.println("1 elefante incomoda muita gente");
		while (i <= 20){
			i++;
				if(i%2 > 0){ //par
						System.out.println( i + " elefantes " + en + " muita gente"); 
					}else{
						System.out.print( i + " elefantes "); 
						  for(y=0; y<i; y++){
						    System.out.print(en + " ");
					}
						System.out.println( "muito mais");
					}
				}
		}
}
