# Hardware-Mon

## Участники Группы
1. Софья Карпова 5130904/10101
2. Григорий Сырбу 5130904/10101
3. Матюшенко Артур 5130904/10101
4. Булгаков Иван 5130904/10101

приложение состоит из двух частей
+ Hardware-Mon.exe
+ Arduino.ino

Arduino подключается к компьютеру через USB для получения данных через com-порт.
Приложение Hardware-Mon собирает данные с компьютерных датчиков, используя библиотеку OpenHardwareMonitor.dll
и отправляет их через com-порт в Arduino для отображения.
### Схема соединения
![image](https://github.com/tuffii/Hardware-Monitor/assets/100721921/cf269178-3597-4b29-b897-c4363179e5c0)

## Стек
+ С#
+ .NET Framework 4.8
+ Arduino

## Модули и библиотеки
OpenHardwareMonitorLib.dll

## Инструкция для запуска
VisualStudio 2019+ с установленными пакетами .NET 4.8
использовать compileApplication.bat для сборки .exe файла

## Демонстрация работы

![image](https://github.com/tuffii/Hardware-Monitor/assets/100721921/91bd7c58-dca6-42f5-88b8-370235bb01cf)
![image](https://github.com/tuffii/Hardware-Monitor/assets/100721921/d867286c-2211-443d-8c47-a72f41403e42)
