# MS Add-in Communication_RS232

## RS232 통신 모듈입니다.

Job 기능 :
1. 기본 SendMessage : 기본적인 SerialPort 메세지 송신입니다.
2. SendMessage + Wait for AckMessage : SerialPort 메세지 송신 이후 원하는 AckMessage 수신까지 대기합니다.
	- AckMessage 내용 설정 가능
	- AckMessage Receive Timeout 설정 가능
