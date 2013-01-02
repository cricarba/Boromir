sqlcmd -S .\SQLEXPRESS -E -i "SQL\1_Boromir_Tables.sql"

sqlcmd -S .\SQLEXPRESS -E -i "SQL\2_Boromir_proc_audit.sql"

sqlcmd -S .\SQLEXPRESS -E -i "SQL\3_Boromir_proc_confirma_movimiento.sql"

sqlcmd -S .\SQLEXPRESS -E -i "SQL\4_Boromir_proc_anular_movimiento.sql"

sqlcmd -S .\SQLEXPRESS -E -i "SQL\5_Boromir_proc_reversar_movimiento.sql"

sqlcmd -S .\SQLEXPRESS -E -i "SQL\6_Boromir_proc_detalles_movimientos.sql"

sqlcmd -S .\SQLEXPRESS -E -i "SQL\7_Boromir_proc_crea_fact_reser.sql"

sqlcmd -S .\SQLEXPRESS -E -i "SQL\8_Boromir_proc_datos_escen.sql"

sqlcmd -S .\SQLEXPRESS -E -i "SQL\9_Boromir_Insert.sql"


PAUSE