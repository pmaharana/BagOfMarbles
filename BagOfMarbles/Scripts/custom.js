let doSomething = () => {
    let _marble = $("#color").val();
    $("#marbleColor").html(_marble)
}


let addToList = (data) => {
    $("#marbleList").append($("<li>").html(data.Color));

}


let talkToServer = () => {

    let newMarble = {
        color: $("#newMarbleColor").val()
        
    };


    $.ajax({

        url: '/api/Marbles',
        dataType: "json",
        contentType: "application/json",    
        data: JSON.stringify(newMarble),
        type: "POST",
        success: (data) => {
            addToList(data);
        },
        error: (data) => {
            console.log("oops", data);
        },
        complete: (data) => {
            console.log("done", data);
        }



    });
}