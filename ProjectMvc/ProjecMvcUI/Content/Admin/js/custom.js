
$(function () {

    // start convert number
    function persianNumbers() {
        try {
            var pNums = {
                0: "۰",
                1: "۱",
                2: "۲",
                3: "۳",
                4: "۴",
                5: "۵",
                6: "۶",
                7: "۷",
                8: "۸",
                9: "۹"
            };

            function convertToPersian(el) {
                var i;

                if (el.nodeType === 3) {
                    var list = el.data.match(/[0-9]/g);
                    if (list != null && list.length !== 0) {
                        for (i = 0; i < list.length; i++)
                            el.data = el.data.replace(list[i], pNums[list[i]]);
                    }
                }
                for (i = 0; i < el.childNodes.length; i++) {
                    convertToPersian(el.childNodes[i]);
                }
            }
            convertToPersian(document.body);
        } catch (e) {

        }
        return false;
    }
    persianNumbers()
    //End convert number

});