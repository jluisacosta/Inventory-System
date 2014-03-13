
SELECT OC.id_orden_compra,OC.fecha_pedido,E.id_empleado,E.nombre,P.razon_social,P.rfc,P.direccion,P.telefono,MP.nombre,MP.unidad,DC.cantidad,MP.precio,OC.iva,DC.subtotal
FROM Ordenes_Compra OC,Proveedores P,Empleados E, Detalle_Compra DC,Materias_Primas MP
WHERE P.id_proveedor = OC.id_proveedor
AND E.id_empleado = OC.id_empleado
AND OC.id_orden_compra = DC.id_orden_compra
AND DC.id_materia_prima = MP.id_materia
AND OC.id_orden_compra = 8




