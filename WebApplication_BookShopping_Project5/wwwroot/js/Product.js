var dataTable;
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData2').DataTable({
        "ajax": {
           "url":"/Admin/Product/GetAll"
        },
        "columns": [
            { "data": "title", "width": "15%" },
            { "data": "discription", "width": "15%" },
           // { "data": "isbn", "width": "15%" },
            
            { "data": "author", "width": "15%" },
            { "data": "price", "width": "15%" },
            { "data": "id", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                         <div class="text-center">
                         <a class="btn btn-success" onclick=Upsert("/Admin/Product/Upsert/${data}")>
                         <i class="fas fa-edit"></i>
                         Edit
                         </a>
                         <a class="btn btn-danger" onclick=Delete("/Admin/Product/Delete/${data}")>
                         <i class="fas fa-trash"></i>
                         Delete
                         </a>
                    `;
                }
            }
        ]
    })
}

function Delete(url) {
    swal({
        title: "Want To Delete Data!!!",
        icon: "error",
        buttons: true,
        text: "Delete Information!!!",
        dangerModel: true
    }).then((willdelete) => {
        if (willdelete) {
            $.ajax({
                url: url,
                type: "Delete",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message)
                        data.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}

function Upsert(url) {
    swal({
        title: "Want To Edit Data!!!",
        icon: "warning",
        buttons: true,
        text: "Edit Information!!!",
        dangerModel: true
    }).then((willdelete) => {
        if (willdelete) {
            $.ajax({
                url: url,
                type: "Put",
                success: function (data) {
                    if (data) {
                        window.location.href = url;
                        //toastr.success(data.message)
                        data.ajax.reload();
                    }
                    //else {
                    //    toastr.error(data.message);
                    //}
                }
            })
        }
    })
}
   
