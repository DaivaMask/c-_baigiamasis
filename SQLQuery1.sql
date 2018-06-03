select Darbas.Id, Darbininkas.Name AS Daro, Darbas.WorkStart AS DarboPradzia, Darbas.WorkDesc from Darbas
 JOIN Darbininkas on Darbas.Worker_ID = Darbininkas.Id