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

## Требования

+ Отображение информации: Система должна считывать информацию о состоянии аппаратных ресурсов компьютера и отображать ее на внешнем дисплее.
+ Подключение к Arduino: Система должна использовать Arduino для управления внешним дисплеем и получения данных с компьютера.
+ COM-порт: Связь между компьютером и Arduino должна осуществляться через COM-порт.
+ OpenHardwareMonitor: Для получения информации о системе необходимо использовать библиотеку OpenHardwareMonitor.

## Высокоуровневая схема
```
graph LR
    subgraph Компьютер
        A[Hardware-Mon.exe] --> B{OpenHardwareMonitorLib.dll}
        A --> C[COM-порт]
    end
    subgraph Arduino
        D[Arduino.ino] <-- C
        D --> E[OLED-дисплей]
    end
```
+ Описание:
  Hardware-Mon.exe (C#/.NET Framework 4.8) - основное приложение на компьютере, отвечающее за:
  Сбор данных о системе с помощью OpenHardwareMonitorLib.dll.
  Формирование сообщений с данными для отправки на Arduino.
  Отправка данных на Arduino через COM-порт.
  OpenHardwareMonitorLib.dll - библиотека, предоставляющая доступ к информации о датчиках аппаратных ресурсов компьютера.
  COM-порт - интерфейс для обмена данными между компьютером и Arduino.
  Arduino.ino (Arduino IDE) - прошивка для Arduino, отвечающая за:
  Прием данных с компьютера через COM-порт.
  Обработку и вывод полученных данных на OLED-дисплей.
  OLED-дисплей - внешний дисплей, подключенный к Arduino, на котором отображается информация о системе.
+ Связи:
  Hardware-Mon.exe использует OpenHardwareMonitorLib.dll для получения данных о системе.
  Hardware-Mon.exe отправляет данные на Arduino через COM-порт.
  Arduino.ino принимает данные с COM-порта и выводит их на OLED-дисплей.

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
