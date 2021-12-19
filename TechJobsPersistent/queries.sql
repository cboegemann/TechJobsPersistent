--Part 1
/*SQL TASK: At this point, you will have tables for Jobs, Employers, Skills, and JobSkills. In queries.sql under “Part 1”, list the columns and their data types in the Jobs table.*/

/* this is the query I ran to find out the columns and their data types*/

SELECT column_name, data_type 
FROM information_schema.columns
WHERE table_name = "jobs"

--Column_Name / Data_Type

Id / int
Name / longtext
EmployerId / int

--Part 2

/*SQL TASK: In queries.sql under “Part 2”, write a query to list the names of the employers in St. Louis City.*/

SELECT name
FROM techjobs.Employers
WHERE location = "St. Louis City"

--Part 3

 /*SQL TASK: In queries.sql under “Part 3”, write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order. If a skill does not have a job listed, it should not be included in the results of this query.*/

SELECT DISTINCT Skills.Name, Skills.Description
FROM JobSkills
RIGHT JOIN Skills
ON JobSkills.SkillId = Skills.Id
WHERE JobSkills.SkillId IS NOT NUll
ORDER BY Skills.Name ASC;