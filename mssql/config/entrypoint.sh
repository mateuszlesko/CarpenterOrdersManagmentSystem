#!/usr/bin/env bash

export STATUS=1
i=0
sleep 20
while [[ $STATUS -ne 0 ]] && [[ $i -lt 20 ]];
do
	i=$i+1
	/opt/mssql-tools18/bin/sqlcmd -C -S localhost -t 1 -U sa -P $MSSQL_SA_PASSWORD -Q "select 1" >> /dev/null
	STATUS=$?
done

if [ $STATUS -ne 0 ]; then 
	echo "======= Error: MSSQL SERVER took more than 20 tries to start up.  ========";
	exit 1
fi

echo "======= MSSQL SERVER STARTED ========"
# Run the setup scripts by add one or more *.sql fles in the /sql folder
for filename in ./sql; do
	/opt/mssql-tools18/bin/sqlcmd -C -S localhost -U sa -P $MSSQL_SA_PASSWORD -i "$filename";
done

echo "======= MSSQL CONFIG COMPLETE ======="