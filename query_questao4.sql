SELECT 
    c.id "Código", 
    c.razao_social "Razao Social", 
    t.numero AS telefone
FROM 
    Cliente c
LEFT JOIN 
    Estado e ON e.id = c.id_estado
LEFT JOIN 
    Telefone t ON t.id = c.id_telefone
WHERE 
    e.codigo = 'SP';
	
	
	
	