
void setup() {
  Serial.begin(9600);
}

void loop() {
  int Heading = analogRead(A0);
  map(Heading, 0, 1024, 0, 360);
  Serial.println(Heading);
  delay(100);
}
