#include <SPI.h>
#include <MFRC522.h>

int green_pin = 6;
int red_pin = 7;

bool alarmActive;

#define RST_PIN         5          
#define SS_PIN          53         

MFRC522 mfrc522(SS_PIN, RST_PIN);  

void setup() {
  pinMode(green_pin, OUTPUT);
  pinMode(red_pin, OUTPUT);
  digitalWrite(green_pin, LOW);
  digitalWrite(red_pin, HIGH);
  Serial.begin(9600);
  while (!Serial);    
  SPI.begin();      
  mfrc522.PCD_Init(); 
  delay(4);       
  mfrc522.PCD_DumpVersionToSerial();  
  alarmActive = false;
}

void loop() {
  //check for incoming instructions
  if(Serial.available())
  {
    String serialData = Serial.readString();
    serialData.trim();
    if(serialData == "Open")
    {
      On_Open(); 
      Serial.println("Open called");
    }
    else if(serialData == "Close")
    {
      On_Close();
      Serial.println("Close called");
    }
    else if(serialData == "SoundAlarm")
    {
      On_SoundAlarm();
      Serial.println("SoundAlarm called");
    }
    else if(serialData == "StopAlarm")
    {
      On_StopAlarm();
      Serial.println("Stop called"); 
    }
  }

  if(alarmActive)//make the alarm take action if is active
  {
    digitalWrite(red_pin, LOW);
    delay(500);
    digitalWrite(red_pin, HIGH);
    delay(500);
  }

  if(mfrc522.PICC_IsNewCardPresent() && mfrc522.PICC_ReadCardSerial())
  {
    Serial.print("UID: ");
    for (int i = 0; i < mfrc522.uid.size; i++) {
      Serial.print(mfrc522.uid.uidByte[i], HEX);
    }
    Serial.println(); 
    
    mfrc522.PICC_HaltA();
  }
}

void On_Open()
{
  On_StopAlarm();
  digitalWrite(green_pin, HIGH);
  digitalWrite(red_pin, LOW);
}

void On_Close()
{
  On_StopAlarm();
  digitalWrite(green_pin, LOW);
  digitalWrite(red_pin, HIGH);
}

void On_SoundAlarm()
{
  digitalWrite(green_pin, LOW);
  digitalWrite(red_pin, LOW);
  alarmActive = true;
}

void On_StopAlarm()
{
  alarmActive = false;
  digitalWrite(green_pin, LOW);
  digitalWrite(red_pin, HIGH);
}
