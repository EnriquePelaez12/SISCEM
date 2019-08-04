using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISCEM
{
    public static class Utilities
    {
             /// <summary>
            /// Funcion booleana encargada buscar y seleccionar un Row de un control DataGridView
            /// 
            /// </summary>            
            /// <typeparam name="T">Tipo de dato del valor bucado</typeparam>
            /// <param name="dgv">Control DataGridView donde se realizara la busqueda</param>
            /// <param name="searchedValue">Valor buscado</param>
            /// <param name="columnIndex">Indice de la columna que contiene el valor a buscar</param>
            /// <returns>True si el valor fue encontrado en caso contrario False</returns>
            public static bool FindValue<T>(DataGridView dgv, T searchedValue, int columnIndex)
            {
                DataGridViewRow row = dgv.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => searchedValue.Equals(Convert.ChangeType(x.Cells[columnIndex].Value, typeof(T))));

                if (row != null)
                {

                    dgv.CurrentCell = dgv.Rows[row.Index].Cells[columnIndex];

                    dgv.FirstDisplayedCell = dgv.CurrentCell;

                    return true;
                }
                return false;
            }

            /// <summary>
            /// Método encargado de Establecer la posición del ultimo Row 
            /// ingresado en un control DataGridView
            /// </summary>
            /// <param name="dgv">Control DataGridView</param>
            public static void DataGridViewRowPosition(DataGridView dgv)
            {
                DataGridViewCell cell = dgv.CurrentCell;
                if (cell == null) return;

                cell = dgv.Rows[dgv.RowCount - 1].Cells[0];
                dgv.CurrentCell = cell;
                if (dgv.CurrentRow != null) dgv.CurrentRow.Selected = true;
            }

            /// <summary>
            /// Método encargado de copiar al Clipboard el valor contenido en el Parametro
            /// dataValue
            /// </summary>
            /// <param name="dataValue"></param>
            public static void CopyCellToClipboard(string dataValue)
            {
                Clipboard.SetText(dataValue);
            }

            /// <summary>
            /// Método encargado de copiar al ClipBoard el valor del Row actual
            /// del control DataGridview enviado
            /// </summary>
            /// <param name="dgv"></param>
            public static void CopyRowToClipboard(DataGridView dgv)
            {
                DataObject dataObj = dgv.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
            }
        }
    }
