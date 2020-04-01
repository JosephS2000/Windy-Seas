
int Heading; //Variable that will be used to get the direction of the ship

void setup() {
  
  Serial.begin(9600); //Begins the serial at 9600 bits per second
}

void loop() {
  
  Heading = analogRead(A0); //Reads what comes out of the A0 port and assigns it to the variable Heading
  
  Heading = map(Heading, 0, 1024, 0, 360); //Maps the 1024 that the potentiometer will give off onto the 360 degrees that the ship will turn in
  
  Serial.println(Heading); //Prints the Heading value to be read
  
  delay(100);//The amount of time delay between the value being printed
}
