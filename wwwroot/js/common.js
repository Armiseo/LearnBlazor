window.showToastr = function (type, message) {
    if (type == "success") {
        toastr.success(message)
    }
    else if (type == "warning") {
        toastr.warning(message)
    }
    else {
        toastr.error(message)
    }
}

window.showSweetAlert = function (type, message) {
    if (type == "success") {
        Swal.fire({
            icon: "success",
            title: "Great Job",
            text: message,
        });
    }
    else {
        Swal.fire({
            icon: "error",
            title: "Oops...",
            text: message,
            footer: "<a href=\"#\">Why do I have this issue?</a>"
        });
    }
}

