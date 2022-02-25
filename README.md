# Examination-system
project for adv-database-systems course in ITI

# team members
- abdelrahman ragab
- hussam saiid
- mohamed fathey
- islam mahrous


# demos and report 
[documentation folder](Database/Documentation)

## database dictionay
[database dictionary](Database/Documentation/Database%20Dictionary.pdf)

## reports 
1. [Topics in Course](Database/Documentation/reports/view%20Topics%20in%20Course%20Sample.pdf)
2. [Exam student Sample](Database/Documentation/reports/view%20Exam%20student%20Sample%20_html.pdf)
3. [Exam with answers sample](Database/Documentation/reports/view%20Exam%20with%20answers%20sample.pdf)
4. [instructor courses](Database/Documentation/reports/view%20instructor%20courses.pdf)
5. [Student grade](Database/Documentation/reports/view%20Student%20grade.pdf)
6. [students_in_department](Database/Documentation/reports/view%20students_in_department.pdf)

## demo
- [full walkthrough](./Demo.mp4)
- [take exam](Database/Documentation/demos/take_exam.webm)
- [open report](Database/Documentation/demos/newUI_ExamAnser.webm)



# running 

## 1. restore database backup 
[database backup](Database/Database%20Backup/Examination.bak)



## 2. run desktop app
- unzip the reslease
- run [Release - Desktop App/FrmHome.exe](Release%20-%20Desktop%20App/frmHome.exe)


# testing credintials

## instructor user
```
username: admin
password: admin
```

## student user
```
username: test
password: test
```



# EERD 
* if you use dark theme click the image for background
![ERD](Database/Design/ERD.drawio.svg)

# mapping to tables

![diagram](Database/Initiate%20Database/diagram.png)


# prepare DEV-environment
run sql scripts in folder `./initiateDB`
or you can use the following command:
```ps
cd initiateDB
.\testEnv.ps1
```
this will 
- create database `examination`
- create all required tables or update them if they already exist
- populate tables with data 


