--1. Необходимо получить всевозможные уникальные пары имен сотрудников некоторого отдела с разными должностями.

SELECT DISTINCT names.NAME, positions.POSITION
FROM 
(SELECT NAME FROM EMPLOYEE) AS names  CROSS JOIN
(SELECT POSITION FROM EMPLOYEE) AS positions



--2. Вывести имена начальников с зарплатой вдвое выше средней его непосредственных подчиненных.

SELECT t1.NAME as BossName, t1.SALARY as BossSalary, t2.AVG_EMPLOYEE_SALARY
FROM EMPLOYEE As t1
JOIN (
SELECT CHIEF_ID, AVG(SALARY) AS AVG_EMPLOYEE_SALARY
FROM EMPLOYEE
GROUP BY CHIEF_ID
) AS t2 ON t1.ID = t2.CHIEF_ID
WHERE t1.SALARY > (t2.AVG_EMPLOYEE_SALARY * 2)
