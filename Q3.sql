


--Q3
--1.
SELECT Game_tbl.PlayerId, Player_tbl.PlayerName, max(Game_tbl.Score)
FROM Game_tbl
INNER JOIN Player_tbl ON Game_tbl.PlayerId=Player_tbl.PlayerId
group by Game_tbl.PlayerId;

--2.	Return players that did not play any game
SELECT Player_tbl.PlayerId,Player_tbl.PlayerName
FROM Player_tbl
LEFT JOIN Game_tbl  ON Game_tbl.PlayerId = Player_tbl.PlayerId
WHERE Game_tbl.PlayerId IS NULL

--3.	Return players that their total score is more than 100
SELECT Game_tbl.PlayerId, Player_tbl.PlayerName, SUM(Game_tbl.Score) PlayerTotal
FROM Game_tbl
INNER JOIN Player_tbl ON Game_tbl.PlayerId=Player_tbl.PlayerId
where PlayerTotal>100
group by Game_tbl.PlayerId;
