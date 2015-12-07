begin tran

pr_tor_get_last_concurso_number

pr_tor_get_best_dezenas 7

--mega-sena
pr_tor_add_dezena_sena 1,982,'20080628',08,12,24,40,43,49
go
pr_tor_add_dezena_sena 1,983,'20080702',16,22,32,38,40,45 
go
pr_tor_add_dezena_sena 1,984,'20080705',04,10,20,43,46,47 
go
pr_tor_add_dezena_sena 1,985,'20080709',04,16,18,46,56,59 
go

--dupla-sena
pr_tor_add_dezena_sena 2,669,'20080627',16,23,30,33,42,43
go
pr_tor_add_dezena_sena 2,670,'20080701',07,10,29,32,43,44
go
pr_tor_add_dezena_sena 2,671,'20080704',01,14,32,34,39,46
go
pr_tor_add_dezena_sena 2,672,'20080708',10,15,19,32,39,41
go

pr_tor_add_dezena_sena 3,669,'20080627',02,22,34,36,37,47
go
pr_tor_add_dezena_sena 3,670,'20080701',01,09,12,16,19,23
go
pr_tor_add_dezena_sena 3,671,'20080704',01,06,21,25,37,40
go
pr_tor_add_dezena_sena 3,672,'20080708',09,21,29,35,39,42
go

pr_tor_add_dezena_loto_mania 840,'20080628',09,14,17,22,28,33,42,43,46,54,55,59,63,66,72,87,94,95,98,99
go
pr_tor_add_dezena_loto_mania 841,'20080702',02,09,11,25,28,35,43,49,70,74,78,81,82,85,87,90,91,94,95,97
go
pr_tor_add_dezena_loto_mania 842,'20080705',08,10,11,18,28,31,37,38,40,45,46,49,55,62,79,81,85,86,91,95
go
pr_tor_add_dezena_loto_mania 843,'20080709',01,07,11,14,17,19,25,31,32,33,37,41,42,47,57,59,71,90,92,98
go


pr_tor_add_dezena_loto_facil 336, '20080707', 01,02,03,05,06,08,10,11,14,15,16,17,19,22,25
go
pr_tor_add_dezena_loto_facil 337, '20080703', 01,03,04,05,07,08,09,10,11,12,16,18,19,22,23
go
pr_tor_add_dezena_loto_facil 338, '20080707', 03,04,05,06,07,09,12,14,15,16,17,19,20,21,25
go


pr_tor_add_dezena_quina 1919, '20080628' , 04,39,46,68,71
go
pr_tor_add_dezena_quina 1920, '20080701' , 08,10,22,66,76
go
pr_tor_add_dezena_quina 1921, '20080703' , 23,60,62,68,80 
go
pr_tor_add_dezena_quina 1922, '20080705' , 47,51,58,60,76 
go
pr_tor_add_dezena_quina 1923, '20080708' , 10,34,37,74,77
go

pr_tor_add_dezena_timemania 18,'20080629',09,15,26,33,54,63,70,33
go
pr_tor_add_dezena_timemania 18,'20080629',26,38,44,49,55,60,75,62
go

pr_tor_get_last_concurso_number

commit tran

rollback tran

--novos concursos
begin tran
go
pr_tor_add_dezena_sena 1,986,'20080712',6,15,19,24,31,32
go
pr_tor_add_dezena_sena 1,987,'20080716',13,27,31,34,47,58
go
pr_tor_add_dezena_sena 1,988,'20080719',8,17,46,48,56,60
go
pr_tor_add_dezena_sena 1,989,'20080723',2,21,27,29,32,38
go
pr_tor_add_dezena_sena 1,990,'20080726',2,10,15,18,29,39
go
pr_tor_add_dezena_sena 1,991,'20080730',8,9,15,38,41,60
go
pr_tor_add_dezena_sena 2,673,'20080711',6,16,32,33,43,47
go
pr_tor_add_dezena_sena 2,674,'20080715',5,7,21,34,39,45
go
pr_tor_add_dezena_sena 2,675,'20080718',6,17,25,30,34,37
go
pr_tor_add_dezena_sena 2,676,'20080722',17,33,34,39,43,45
go
pr_tor_add_dezena_sena 2,677,'20080725',3,9,15,20,41,45
go
pr_tor_add_dezena_sena 2,678,'20080729',1,4,26,28,36,46
go
pr_tor_add_dezena_sena 3,673,'20080711',12,13,16,37,43,50
go
pr_tor_add_dezena_sena 3,674,'20080715',2,3,8,35,36,49
go
pr_tor_add_dezena_sena 3,675,'20080718',2,15,16,17,19,44
go
pr_tor_add_dezena_sena 3,676,'20080722',7,22,23,34,37,49
go
pr_tor_add_dezena_sena 3,677,'20080725',6,12,17,31,42,45
go
pr_tor_add_dezena_sena 3,678,'20080729',2,4,7,18,30,42
go
pr_tor_add_dezena_loto_mania 844,'20080712',6,11,13,15,24,25,26,29,33,34,35,44,49,68,77,79,82,86,90,91
go
pr_tor_add_dezena_loto_mania 845,'20080716',1,5,6,9,18,19,21,22,40,41,42,48,52,55,66,67,85,88,89,99
go
pr_tor_add_dezena_loto_mania 846,'20080719',3,4,5,11,28,30,38,41,43,50,51,52,53,56,64,66,70,71,82,90
go
pr_tor_add_dezena_loto_mania 847,'20080723',6,7,8,12,19,25,30,45,47,53,58,61,65,71,77,79,85,86,88,97
go
pr_tor_add_dezena_loto_mania 848,'20080726',10,16,20,26,40,51,60,61,62,63,65,70,73,74,75,76,81,88,93,96
go
pr_tor_add_dezena_loto_mania 849,'20080730',1,5,8,12,16,18,23,35,42,43,47,51,53,55,57,63,65,70,74,75
go
pr_tor_add_dezena_loto_facil 339,'20080711',1,2,5,8,10,13,15,16,18,19,20,21,22,23,24
go
pr_tor_add_dezena_loto_facil 340,'20080714',2,3,4,5,6,8,9,10,11,14,19,20,21,22,25
go
pr_tor_add_dezena_loto_facil 341,'20080717',1,5,7,9,11,12,13,16,18,19,20,21,22,24,25
go
pr_tor_add_dezena_loto_facil 342,'20080721',1,3,4,8,11,12,13,15,16,19,20,21,22,23,25
go
pr_tor_add_dezena_loto_facil 343,'20080724',3,5,6,8,11,12,13,14,15,16,18,19,20,22,25
go
pr_tor_add_dezena_loto_facil 344,'20080728',3,4,5,6,9,10,11,12,13,15,16,20,21,24,25
go
pr_tor_add_dezena_loto_facil 345,'20080731',2,7,9,11,12,14,15,16,18,19,20,21,23,24,25
go
pr_tor_add_dezena_quina 1924,'20080710',24,40,42,52,74
go
pr_tor_add_dezena_quina 1925,'20080712',4,39,50,62,76
go
pr_tor_add_dezena_quina 1926,'20080715',2,20,23,43,51
go
pr_tor_add_dezena_quina 1927,'20080717',12,28,29,34,71
go
pr_tor_add_dezena_quina 1928,'20080719',26,28,51,64,74
go
pr_tor_add_dezena_quina 1929,'20080722',20,48,60,73,77
go
pr_tor_add_dezena_quina 1930,'20080724',8,39,48,71,75
go
pr_tor_add_dezena_quina 1931,'20080726',17,42,48,54,68
go
pr_tor_add_dezena_quina 1932,'20080729',14,27,32,51,58
go
pr_tor_add_dezena_quina 1933,'20080731',9,40,60,61,67
go
pr_tor_add_dezena_timemania 19,'20080706',26,38,44,49,55,60,75,62
go
pr_tor_add_dezena_timemania 20,'20080713',19,28,37,39,53,64,73,28
go
pr_tor_add_dezena_timemania 21,'20080720',1,15,46,59,65,75,80,11
go
pr_tor_add_dezena_timemania 22,'20080727',4,7,21,52,55,60,78,32
go

pr_tor_get_last_concurso_number

commit tran

rollback tran