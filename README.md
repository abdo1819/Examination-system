# Examination-system
project for adv-database-systems course in ITI
an Examination system

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








# demos and report 
[documentation folder](Database/Documentation)
## reports 
1. [Topics in Course](./Database/Documentation/view%20Topics%20in%20Course%20Sample.pdf)
2. [Exam student Sample](./Database/Documentation/view%20Exam%20student%20Sample%20_html.pdf)
3. [Exam with answers sample](./Database/Documentation/view%20Exam%20with%20answers%20sample.pdf)
4. [instructor courses](./Database/Documentation/view%20instructor%20courses.pdf)
5. [Student grade](./Database/Documentation/view%20Student%20grade.pdf)
6. [students_in_department](./Database/Documentation/view%20students_in_department.pdf)

## demos
- [full walkthrough](./Demo.mp4)
- [take exam](./Database/Documentation/take_exam.webm)
- [open report](./Database/Documentation/newUI_ExamAnser.webm)


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
- [x] create database `examination`
- [x] create all required tables or update them if they already exist
- [x] populate tables with data 



