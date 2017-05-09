//========================== Declaring Inputs ==========================//
const int CH1_CO_I      = 22;     // Channel 1 CutOff In
const int CH1_FR_I      = 24;     // Channel 1 Frequency Response In
const int CH1_IC_I      = 26;     // Channel 1 Impedance Calibration In
const int CH1_IR_I      = 28;     // Channel 1 Impedance Response In

const int CH2_CO_I      = 30;     // Channel 2 CutOff In
const int CH2_FR_I      = 32;     // Channel 2 Frequency Response In
const int CH2_IC_I      = 34;     // Channel 2 Impedance Calibration In
const int CH2_IR_I      = 36;     // Channel 2 Impedance Response In

const int CH3_CO_I      = 38;     // Channel 3 CutOff In
const int CH3_FR_I      = 40;     // Channel 3 Frequency Response In
const int CH3_IC_I      = 42;     // Channel 3 Impedance Calibration In
const int CH3_IR_I      = 44;     // Channel 3 Impedance Response In

const int CH4_CO_I      = 46;     // Channel 4 CutOff In
const int CH4_FR_I      = 48;     // Channel 4 Frequency Response In
const int CH4_IC_I      = 50;     // Channel 4 Impedance Calibration In
const int CH4_IR_I      = 52;     // Channel 4 Impedance Response In
//======================================================================//

//========================= Declaring Outputs ==========================//
// Relays
const int CH1_CO_O      = 29;     // Channel 1 CutOff Out
const int CH1_TM_O      = 27;     // Channel 1 Toggle Mode Out
const int CH1_TI_O      = 25;     // Channel 1 Toggle Impedance Mode Out

const int CH2_CO_O      = 37;     // Channel 2 CutOff Out
const int CH2_TM_O      = 35;     // Channel 2 Toggle Mode Out
const int CH2_TI_O      = 33;     // Channel 2 Toggle Impedance Mode Out

const int CH3_CO_O      = 45;     // Channel 3 CutOff Out
const int CH3_TM_O      = 43;     // Channel 3 Toggle Mode Out
const int CH3_TI_O      = 41;     // Channel 3 Toggle Impedance Mode Out

const int CH4_CO_O      = 53;     // Channel 4 CutOff Out
const int CH4_TM_O      = 51;     // Channel 4 Toggle Mode Out
const int CH4_TI_O      = 49;     // Channel 4 Toggle Impedance Mode Out

// LEDs
const int CH1_CO_LED    = A0;
const int CH1_FR_LED    = A1;
const int CH1_IC_LED    = A2;
const int CH1_IR_LED    = A3;

const int CH2_CO_LED    = A4;
const int CH2_FR_LED    = A5;
const int CH2_IC_LED    = A6;
const int CH2_IR_LED    = A7;

const int CH3_CO_LED    = A8;
const int CH3_FR_LED    = A9;
const int CH3_IC_LED    = A10;
const int CH3_IR_LED    = A11;

const int CH4_CO_LED    = A12;
const int CH4_FR_LED    = A13;
const int CH4_IC_LED    = A14;
const int CH4_IR_LED    = A15;
//======================================================================//

//==================== Declaring Changing Variables ====================//
int CO_O;
int TI_O;
int TM_O;

int CO_LED;
int FR_LED;
int IC_LED;
int IR_LED;


char compin;
String ser;
int state1;
int state2;
int state3;
int state4;

String RET_STR;
String VER_STR;
String VER_STR1;
String VER_STR2;
String VER_STR3;
String VER_STR4;

volatile int CH1_CO_I_reading;
volatile int CH1_FR_I_reading;
volatile int CH1_IC_I_reading;
volatile int CH1_IR_I_reading;

volatile int CH2_CO_I_reading;
volatile int CH2_FR_I_reading;
volatile int CH2_IC_I_reading;
volatile int CH2_IR_I_reading;

volatile int CH3_CO_I_reading;
volatile int CH3_FR_I_reading;
volatile int CH3_IC_I_reading;
volatile int CH3_IR_I_reading;

volatile int CH4_CO_I_reading;
volatile int CH4_FR_I_reading;
volatile int CH4_IC_I_reading;
volatile int CH4_IR_I_reading;

//======================================================================//

void setup() {
  pinMode(CH1_CO_I, INPUT_PULLUP);
  pinMode(CH1_FR_I, INPUT_PULLUP);
  pinMode(CH1_IC_I, INPUT_PULLUP);
  pinMode(CH1_IR_I, INPUT_PULLUP);

  pinMode(CH2_CO_I, INPUT_PULLUP);
  pinMode(CH2_FR_I, INPUT_PULLUP);
  pinMode(CH2_IC_I, INPUT_PULLUP);
  pinMode(CH2_IR_I, INPUT_PULLUP);

  pinMode(CH3_CO_I, INPUT_PULLUP);
  pinMode(CH3_FR_I, INPUT_PULLUP);
  pinMode(CH3_IC_I, INPUT_PULLUP);
  pinMode(CH3_IR_I, INPUT_PULLUP);

  pinMode(CH4_CO_I, INPUT_PULLUP);
  pinMode(CH4_FR_I, INPUT_PULLUP);
  pinMode(CH4_IC_I, INPUT_PULLUP);
  pinMode(CH4_IR_I, INPUT_PULLUP);

  
  pinMode(CH1_CO_O, OUTPUT);
  pinMode(CH1_TM_O, OUTPUT);
  digitalWrite(CH1_TM_O, LOW); // ES DPDT
  pinMode(CH1_TI_O, OUTPUT);
  digitalWrite(CH1_TI_O, HIGH);
  
  pinMode(CH2_CO_O, OUTPUT);
  pinMode(CH2_TM_O, OUTPUT);
  digitalWrite(CH2_TM_O, LOW); // ES DPDT
  pinMode(CH2_TI_O, OUTPUT);
  digitalWrite(CH2_TI_O, HIGH);

  pinMode(CH3_CO_O, OUTPUT);
  pinMode(CH3_TM_O, OUTPUT);
  digitalWrite(CH3_TM_O, LOW); // ES DPDT
  pinMode(CH3_TI_O, OUTPUT);
  digitalWrite(CH3_TI_O, HIGH);

  pinMode(CH4_CO_O, OUTPUT);
  pinMode(CH4_TM_O, OUTPUT);
  digitalWrite(CH4_TM_O, LOW); // ES DPDT
  pinMode(CH4_TI_O, OUTPUT);
  digitalWrite(CH4_TI_O, HIGH);

  pinMode(CH1_CO_LED, OUTPUT);
  digitalWrite(CH1_CO_LED, HIGH);
  pinMode(CH1_FR_LED, OUTPUT);
  pinMode(CH1_IC_LED, OUTPUT);
  pinMode(CH1_IR_LED, OUTPUT);

  pinMode(CH2_CO_LED, OUTPUT);
  digitalWrite(CH2_CO_LED, HIGH);
  pinMode(CH2_FR_LED, OUTPUT);
  pinMode(CH2_IC_LED, OUTPUT);
  pinMode(CH2_IR_LED, OUTPUT);

  pinMode(CH3_CO_LED, OUTPUT);
  digitalWrite(CH3_CO_LED, HIGH);
  pinMode(CH3_FR_LED, OUTPUT);
  pinMode(CH3_IC_LED, OUTPUT);
  pinMode(CH3_IR_LED, OUTPUT);

  pinMode(CH4_CO_LED, OUTPUT);
  digitalWrite(CH4_CO_LED, HIGH);
  pinMode(CH4_FR_LED, OUTPUT);
  pinMode(CH4_IC_LED, OUTPUT);
  pinMode(CH4_IR_LED, OUTPUT);
  
  attachInterrupt(digitalPinToInterrupt(18), CH1_ISR, CHANGE);
  attachInterrupt(digitalPinToInterrupt(19), CH2_ISR, CHANGE);
  attachInterrupt(digitalPinToInterrupt(20), CH3_ISR, CHANGE);
  attachInterrupt(digitalPinToInterrupt(21), CH4_ISR, CHANGE);

  Serial.begin(9600);
  Serial.println("@Connected#");
}

void loop() {
  if (Serial.available()) {
    delay(50);        
    while(Serial.available()>0){
      compin = Serial.read();
      if (compin == '@'){
        while(Serial.available()>0){
          compin = Serial.read();
          if (compin == '#'){ 
            break;
          }
          ser = ser + compin; 
        }

//======================================================================//
        if (ser.charAt(0) == 'v'){
          state4 = (PORTK & 0x00F0) >> 4;
          state3 = (PORTK & 0x000F) >> 0;
          state2 = (PORTF & 0x00F0) >> 4;
          state1 = (PORTF & 0x000F) >> 0;
          if ( state1 ==  1 ){
            VER_STR1 = "CH1_CO";
          }
          else if ( state1 == 2 ){
            VER_STR1 = "CH1_FR";
          }
          else if ( state1 == 4 ){
            VER_STR1 = "CH1_IC";
          }
          else
            VER_STR1 = "CH1_IR";
            
          if ( state2 ==  1 ){
            VER_STR2 = "CH2_CO";
          }
          else if ( state2 == 2 ){
            VER_STR2 = "CH2_FR";
          }
          else if ( state2 == 4 ){
            VER_STR2 = "CH2_IC";
          }
          else
            VER_STR2 = "CH2_IR";
            
          if ( state3 ==  1 ){
            VER_STR3 = "CH3_CO";
          }
          else if ( state3 == 2 ){
            VER_STR3 = "CH3_FR";
          }
          else if ( state3 == 4 ){
            VER_STR3 = "CH3_IC";
          }
          else
            VER_STR3 = "CH3_IR";
            
          if ( state4 ==  1 ){
            VER_STR4 = "CH4_CO";
          }
          else if ( state4 == 2 ){
            VER_STR4 = "CH4_FR";
          }
          else if ( state4 == 4 ){
            VER_STR4 = "CH4_IC";
          }
          else
            VER_STR4 = "CH4_IR";

          VER_STR = "@,"+VER_STR1+","+VER_STR2+","+VER_STR3+","+VER_STR4+",#";
          Serial.println(VER_STR);
        }
  
        if (ser.charAt(2) == '1'){
          CO_O = CH1_CO_O; 
          TM_O = CH1_TM_O;
          TI_O = CH1_TI_O;
          CO_LED = CH1_CO_LED;
          FR_LED = CH1_FR_LED;
          IC_LED = CH1_IC_LED;
          IR_LED = CH1_IR_LED;
          RET_STR = "@CH1";
        }

        if (ser.charAt(2) == '2'){
          CO_O = CH2_CO_O; 
          TM_O = CH2_TM_O;
          TI_O = CH2_TI_O;
          CO_LED = CH2_CO_LED;
          FR_LED = CH2_FR_LED;
          IC_LED = CH2_IC_LED;
          IR_LED = CH2_IR_LED;
          RET_STR = "@CH2";
        }

        if (ser.charAt(2) == '3'){
          CO_O = CH3_CO_O; 
          TM_O = CH3_TM_O;
          TI_O = CH3_TI_O;
          CO_LED = CH3_CO_LED;
          FR_LED = CH3_FR_LED;
          IC_LED = CH3_IC_LED;
          IR_LED = CH3_IR_LED;          
          RET_STR = "@CH3";
        }

        if (ser.charAt(2) == '4'){
          CO_O = CH4_CO_O; 
          TM_O = CH4_TM_O;
          TI_O = CH4_TI_O;
          CO_LED = CH4_CO_LED;
          FR_LED = CH4_FR_LED;
          IC_LED = CH4_IC_LED;
          IR_LED = CH4_IR_LED;
          RET_STR = "@CH4";
        }

//======================================================================//
        
        if (ser.charAt(4) == 'c' && ser.charAt(5) == 'o'){
          digitalWrite(CO_O, LOW);    // LOW for relay boards, not relays
          digitalWrite(CO_LED, HIGH);
          digitalWrite(FR_LED, LOW);
          digitalWrite(IC_LED, LOW);
          digitalWrite(IR_LED, LOW);
          delay(100);
          RET_STR = RET_STR + "_CO#";
          Serial.println(RET_STR);
        }

        if (ser.charAt(4) == 'f' && ser.charAt(5) == 'r'){
          digitalWrite(CO_O, HIGH);   // Make sure speaker is connected
          digitalWrite(TM_O, LOW);   // Go to frequency response mode (ES DPDT)
          digitalWrite(CO_LED, LOW);
          digitalWrite(FR_LED, HIGH);
          digitalWrite(IC_LED, LOW);
          digitalWrite(IR_LED, LOW);
          delay(100);
          RET_STR = RET_STR + "_FR#";
          Serial.println(RET_STR);
        }

        if (ser.charAt(4) == 'i' && ser.charAt(5) == 'c'){
          digitalWrite(CO_O, HIGH);   // Make sure speaker is connected
          digitalWrite(TM_O, HIGH);    // Go to impedance mode (ES DPDT)
          digitalWrite(TI_O, LOW);    // Go to impedance calibration mode
          digitalWrite(CO_LED, LOW);
          digitalWrite(FR_LED, LOW);
          digitalWrite(IC_LED, HIGH);
          digitalWrite(IR_LED, LOW);
          delay(100);
          RET_STR = RET_STR + "_IC#";
          Serial.println(RET_STR);
        }

        if (ser.charAt(4) == 'i' && ser.charAt(5) == 'r'){
          digitalWrite(CO_O, HIGH);   // Make sure speaker is connected
          digitalWrite(TM_O, HIGH);    // Go to impedance mode (ES DPDT)
          digitalWrite(TI_O, HIGH);   // Go to impedance response mode
          digitalWrite(CO_LED, LOW);
          digitalWrite(FR_LED, LOW);
          digitalWrite(IC_LED, LOW);
          digitalWrite(IR_LED, HIGH);
          delay(100);
          RET_STR = RET_STR + "_IR#";
          Serial.println(RET_STR);
        }

//======================================================================//
      } 
    }   
  ser = "";
  RET_STR = "";          
  }    
}
//======================================================================//

//===================== Interrupt Service Routines =====================// 

void CH1_ISR() {

  CH1_CO_I_reading = digitalRead(CH1_CO_I);
  CH1_FR_I_reading = digitalRead(CH1_FR_I);
  CH1_IC_I_reading = digitalRead(CH1_IC_I);
  CH1_IR_I_reading = digitalRead(CH1_IR_I);

  if (CH1_CO_I_reading == LOW) {
    digitalWrite(CH1_CO_O, LOW);    // LOW for relay boards, not relays
    digitalWrite(CH1_CO_LED, HIGH);
    digitalWrite(CH1_FR_LED, LOW);
    digitalWrite(CH1_IC_LED, LOW);
    digitalWrite(CH1_IR_LED, LOW);
    delay(100);
  }

  if (CH1_FR_I_reading == LOW) {
    digitalWrite(CH1_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH1_TM_O, LOW);   // Go to frequency response mode (ES DPDT)
    digitalWrite(CH1_CO_LED, LOW);
    digitalWrite(CH1_FR_LED, HIGH);
    digitalWrite(CH1_IC_LED, LOW);
    digitalWrite(CH1_IR_LED, LOW);
    delay(100);
  }

  if (CH1_IC_I_reading == LOW) {
    digitalWrite(CH1_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH1_TM_O, HIGH);    // Go to impedance mode (ES DPDT)
    digitalWrite(CH1_TI_O, LOW);    // Go to impedance calibration mode
    digitalWrite(CH1_CO_LED, LOW);
    digitalWrite(CH1_FR_LED, LOW);
    digitalWrite(CH1_IC_LED, HIGH);
    digitalWrite(CH1_IR_LED, LOW);
    delay(100);
  }

  if (CH1_IR_I_reading == LOW) {
    digitalWrite(CH1_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH1_TM_O, HIGH);    // Go to impedance mode (ES DPDT)
    digitalWrite(CH1_TI_O, HIGH);   // Go to impedance response mode
    digitalWrite(CH1_CO_LED, LOW);
    digitalWrite(CH1_FR_LED, LOW);
    digitalWrite(CH1_IC_LED, LOW);
    digitalWrite(CH1_IR_LED, HIGH);
    delay(100);
  }

}

void CH2_ISR() {

  CH2_CO_I_reading = digitalRead(CH2_CO_I);
  CH2_FR_I_reading = digitalRead(CH2_FR_I);
  CH2_IC_I_reading = digitalRead(CH2_IC_I);
  CH2_IR_I_reading = digitalRead(CH2_IR_I);

  if (CH2_CO_I_reading == LOW) {
    digitalWrite(CH2_CO_O, LOW);    // LOW for relay boards, not relays
    digitalWrite(CH2_CO_LED, HIGH);
    digitalWrite(CH2_FR_LED, LOW);
    digitalWrite(CH2_IC_LED, LOW);
    digitalWrite(CH2_IR_LED, LOW);
    delay(100);
  }

  if (CH2_FR_I_reading == LOW) {
    digitalWrite(CH2_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH2_TM_O, LOW);    // Go to frequency response mode (ES DPDT)
    digitalWrite(CH2_CO_LED, LOW);
    digitalWrite(CH2_FR_LED, HIGH);
    digitalWrite(CH2_IC_LED, LOW);
    digitalWrite(CH2_IR_LED, LOW);
    delay(100);
  }

  if (CH2_IC_I_reading == LOW) {
    digitalWrite(CH2_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH2_TM_O, HIGH);   // Go to impedance mode (ES DPDT)
    digitalWrite(CH2_TI_O, LOW);    // Go to impedance calibration mode
    digitalWrite(CH2_CO_LED, LOW);
    digitalWrite(CH2_FR_LED, LOW);
    digitalWrite(CH2_IC_LED, HIGH);
    digitalWrite(CH2_IR_LED, LOW);
    delay(100);
  }

  if (CH2_IR_I_reading == LOW) {
    digitalWrite(CH2_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH2_TM_O, HIGH);    // Go to impedance mode (ES DPDT)
    digitalWrite(CH2_TI_O, HIGH);   // Go to impedance response mode
    digitalWrite(CH2_CO_LED, LOW);
    digitalWrite(CH2_FR_LED, LOW);
    digitalWrite(CH2_IC_LED, LOW);
    digitalWrite(CH2_IR_LED, HIGH);
    delay(100);
  }

}

void CH3_ISR() {

  CH3_CO_I_reading = digitalRead(CH3_CO_I);
  CH3_FR_I_reading = digitalRead(CH3_FR_I);
  CH3_IC_I_reading = digitalRead(CH3_IC_I);
  CH3_IR_I_reading = digitalRead(CH3_IR_I);

  if (CH3_CO_I_reading == LOW) {
    digitalWrite(CH3_CO_O, LOW);    // LOW for relay boards, not relays
    digitalWrite(CH3_CO_LED, HIGH);
    digitalWrite(CH3_FR_LED, LOW);
    digitalWrite(CH3_IC_LED, LOW);
    digitalWrite(CH3_IR_LED, LOW);
    delay(100);
  }

  if (CH3_FR_I_reading == LOW) {
    digitalWrite(CH3_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH3_TM_O, LOW);    // Go to frequency response mode (ES DPDT)
    digitalWrite(CH3_CO_LED, LOW);
    digitalWrite(CH3_FR_LED, HIGH);
    digitalWrite(CH3_IC_LED, LOW);
    digitalWrite(CH3_IR_LED, LOW);
    delay(100);
  }

  if (CH3_IC_I_reading == LOW) {
    digitalWrite(CH3_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH3_TM_O, HIGH);   // Go to impedance mode (ES DPDT)
    digitalWrite(CH3_TI_O, LOW);    // Go to impedance calibration mode
    digitalWrite(CH3_CO_LED, LOW);
    digitalWrite(CH3_FR_LED, LOW);
    digitalWrite(CH3_IC_LED, HIGH);
    digitalWrite(CH3_IR_LED, LOW);
    delay(100);
  }

  if (CH3_IR_I_reading == LOW) {
    digitalWrite(CH3_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH3_TM_O, HIGH);    // Go to impedance mode (ES DPDT)
    digitalWrite(CH3_TI_O, HIGH);   // Go to impedance response mode
    digitalWrite(CH3_CO_LED, LOW);
    digitalWrite(CH3_FR_LED, LOW);
    digitalWrite(CH3_IC_LED, LOW);
    digitalWrite(CH3_IR_LED, HIGH);
    delay(100);
  }

}

void CH4_ISR() {

  CH4_CO_I_reading = digitalRead(CH4_CO_I);
  CH4_FR_I_reading = digitalRead(CH4_FR_I);
  CH4_IC_I_reading = digitalRead(CH4_IC_I);
  CH4_IR_I_reading = digitalRead(CH4_IR_I);

  if (CH4_CO_I_reading == LOW) {
    digitalWrite(CH4_CO_O, LOW);    // LOW for relay boards, not relays
    digitalWrite(CH4_CO_LED, HIGH);
    digitalWrite(CH4_FR_LED, LOW);
    digitalWrite(CH4_IC_LED, LOW);
    digitalWrite(CH4_IR_LED, LOW);
    delay(100);
  }

  if (CH4_FR_I_reading == LOW) {
    digitalWrite(CH4_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH4_TM_O, LOW);   // Go to frequency response mode (ES DPDT)
    digitalWrite(CH4_CO_LED, LOW);
    digitalWrite(CH4_FR_LED, HIGH);
    digitalWrite(CH4_IC_LED, LOW);
    digitalWrite(CH4_IR_LED, LOW);
    delay(100);
  }

  if (CH4_IC_I_reading == LOW) {
    digitalWrite(CH4_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH4_TM_O, HIGH);    // Go to impedance mode (ES DPDT)
    digitalWrite(CH4_TI_O, LOW);    // Go to impedance calibration mode
    digitalWrite(CH4_CO_LED, LOW);
    digitalWrite(CH4_FR_LED, LOW);
    digitalWrite(CH4_IC_LED, HIGH);
    digitalWrite(CH4_IR_LED, LOW);
    delay(100);
  }

  if (CH4_IR_I_reading == LOW) {
    digitalWrite(CH4_CO_O, HIGH);   // Make sure speaker is connected
    digitalWrite(CH4_TM_O, HIGH);   // Go to impedance mode (ES DPDT)
    digitalWrite(CH4_TI_O, HIGH);   // Go to impedance response mode
    digitalWrite(CH4_CO_LED, LOW);
    digitalWrite(CH4_FR_LED, LOW);
    digitalWrite(CH4_IC_LED, LOW);
    digitalWrite(CH4_IR_LED, HIGH);
    delay(100);
  }

}
//======================================================================//
