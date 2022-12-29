var dataTable;
$(document).ready(function () {
    loadDataTable();
})
function loadDataTable() {
    dataTable = $('#tblData1').DataTable({
        "ajax": {
            "url": "/Admin/CoverType/GetAll"
        },
        "columns": [
            { "data": "name", "width": "70%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a class="btn btn-success" onclick=Upsert("/Admin/CoverType/Upsert/${data}")>
                                <i class="fas fa-edit"></i>
                                Edit
                            </a>
                            <a class="btn btn-danger" onclick=Delete("/Admin/CoverType/Delete/${data}")>
                               <i class="fa-solid fa-trash-can"></i>
                               Delete
                            </a>
                        </div>
                    `
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
