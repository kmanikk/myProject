var dataTable;
$(document).ready(function () {
    loadDataTable();
})
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Category/GetAll"
        },
        "columns": [
            { "data": "name", "width": "70%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a class="btn btn-success" href="/Admin/Category/Upsert/${data}">
                                <i class="fas fa-edit"></i>
                                Edit
                            </a>
                            <a class="btn btn-danger" onclick=Delete("/Admin/Category/Delete/${data}")>
                               <i class="fa-solid fa-trash-can"></i>
                               Delete
                            </a>
                        </div>
                    `;
                }
            }
        ]

    })
}

function Delete(url) {
    swal({
        title: "Want to Delete Data?",
        icon: "error",
        text: "Delete Information!!",
        buttons: true,
        dangerModel: true
    }).then((willdelete) => {
        if (willdelete) {
            $.ajax({
                url: url,
                type: "Delete",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}
