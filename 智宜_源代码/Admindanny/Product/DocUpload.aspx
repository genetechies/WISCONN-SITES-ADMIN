<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocUpload.aspx.cs" Inherits="ZeroStudio.Web.Admin.Product.DocUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>文檔批量上傳</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../styles/blue_2010.css" rel="stylesheet" type="text/css" />
     <script type="text/javascript" src="/admindanny/ueditor/third-party/jquery-1.10.2.min.js"></script>
    <!-- webuploader -->
    <script src="/admindanny/ueditor/third-party/webuploader/webuploader.min.js"></script>
    <link rel="stylesheet" type="text/css" href="/admindanny/ueditor/third-party/webuploader/webuploader.css">
    <link rel="stylesheet" type="text/css" href="/admindanny/ueditor/dialogs/image/image.css">
     <script type="text/javascript" charset="utf-8" src="/admindanny/ueditor/ueditor.config.js"></script>
    <script type="text/javascript" charset="utf-8" src="/admindanny/ueditor/ueditor.all.min.js"> </script>
</head>
<body leftmargin="10" topmargin="10" marginwidth="10" marginheight="10">
    <form id="form1" runat="server">
        <div class="BodyRight">
            <div class="RightDetill">
                <ul>
                </ul>
            </div>

            <div class="PageContent">
                <table width="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td class="LineRightBlue1">
                            <table width="95%" border="0" cellpadding="0" cellspacing="0" style="margin-left: 20px;">
                                <tr>
                                    <td width="88%" height="24">產品管理 > 文檔批量上傳</td>
                                    <td width="12%" align="right"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <table width="100%" border="0" cellspacing="0" cellpadding="0" class="ListCategory" style="margin-top: 10px;">
                    <tr>
                        <td style="border: none;">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0" class="Font">
                                <tr class="secondalt">
                                    <td valign="top" style="padding-left: 10px; padding-top: 3px; padding-bottom: 3px;"><span>使用說明</span></td>
                                    <td style="padding-top: 3px; padding-bottom: 3px;">
                                        <div style="line-height: 18px;"><b>(1)</b> 最佳文檔大小為5mb內，支持office檔案、pdf檔案;</div>
                                        <div style="line-height: 18px;"><b>(2)</b> 每次可上傳總批量爲5Mb;</div>
                                    </td>
                                </tr>
                                <tr class="secondalt">
                                    <td valign="top" style="padding-left: 10px; padding-top: 3px; padding-bottom: 3px;"><span>上傳批量文檔</span></td>
                                    <td style="padding-top: 3px; padding-bottom: 3px;">
                                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"></asp:LinkButton>
                                        <asp:Label ID="Result" runat="server"></asp:Label>
                                        <div class="wrapper" style="height: 600px">
                                            <div id="tabhead" class="tabhead">
                                                <span class="tab focus" data-content-id="upload">
                                                    <var id="lang_tab_upload">上傳檔案</var></span>
                                            </div>
                                            <div id="tabbody" class="tabbody" style="height: 600px">
                                                <!-- 上傳圖片 -->
                                                <div id="upload" class="panel focus" style="height: 600px">
                                                    <div id="queueList" class="queueList">
                                                        <div class="statusBar element-invisible">
                                                            <div class="progress">
                                                                <span class="text">0%</span>
                                                                <span class="percentage"></span>
                                                            </div>
                                                            <div class="info"></div>
                                                            <div class="btns">
                                                                <div id="filePickerBtn"></div>
                                                                <div class="uploadBtn">
                                                                    開始上傳
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div id="dndArea" class="placeholder">
                                                            <div class="filePickerContainer">
                                                                <div id="filePickerReady"></div>
                                                            </div>
                                                        </div>
                                                        <ul class="filelist element-invisible">
                                                            <li id="filePickerBlock" class="filePickerBlock"></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
<script type="text/javascript">
    var lang = {
        'static': {
            'lang_tab_upload': '上傳附件',
            'lang_tab_online': '在线附件',
            'lang_start_upload': "開始上傳",
            'lang_drop_remind': "可以将檔案拖到这里，单次最多可選100個檔案"
        },
        'uploadSelectFile': '點擊選擇檔案',
        'uploadAddFile': '繼續增加',
        'uploadStart': '開始上傳',
        'uploadPause': '暂停上傳',
        'uploadContinue': '繼續上傳',
        'uploadRetry': '重试上傳',
        'uploadDelete': '删除',
        'uploadTurnLeft': '向左旋转',
        'uploadTurnRight': '向右旋转',
        'uploadPreview': '預覽中',
        'updateStatusReady': '選中_個檔案，共_KB。',
        'updateStatusConfirm': '已成功上傳_個檔案，_個檔案上傳失败',
        'updateStatusFinish': '共_個（_KB），_個上傳成功',
        'updateStatusError': '，_張上傳失败。',
        'errorNotSupport': 'WebUploader 不支持您的浏览器！如果你使用的是IE浏览器，请尝试升级 flash 播放器。',
        'errorLoadConfig': '后端配置项没有正常加载，上傳插件不能正常使用！',
        'errorExceedSize': '檔案大小超出',
        'errorFileType': '檔案格式不允许',
        'errorInterrupt': '檔案传输中断',
        'errorUploadRetry': '上傳失败，请重试',
        'errorHttp': 'http请求错误',
        'errorServerUpload': '服务器返回出错'
    };
    function initUploader() {
        var browser = UE.browser;
        $ = jQuery,    // just in case. Make sure it's not an other libaray.
            this.$wrap = $('#queueList');
        this.$queue = this.$wrap.find('.filelist');
        var _this = this,
            $wrap = _this.$wrap,
            // 圖片容器
            $queue = $wrap.find('.filelist'),
            // 状态栏，包括进度和控制按钮
            $statusBar = $wrap.find('.statusBar'),
            // 檔案总体選擇信息。
            $info = $statusBar.find('.info'),
            // 上傳按钮
            $upload = $wrap.find('.uploadBtn'),
            // 上傳按钮
            $filePickerBtn = $wrap.find('.filePickerBtn'),
            // 上傳按钮
            $filePickerBlock = $wrap.find('.filePickerBlock'),
            // 没選擇檔案之前的内容。
            $placeHolder = $wrap.find('.placeholder'),
            // 总体进度条
            $progress = $statusBar.find('.progress').hide(),
            // 添加的檔案数量
            fileCount = 0,
            // 添加的檔案总大小
            fileSize = 0,
            // 优化retina, 在retina下这個值是2
            ratio = window.devicePixelRatio || 1,
            // 缩略图大小
            thumbnailWidth = 113 * ratio,
            thumbnailHeight = 113 * ratio,
            // 可能有pedding, ready, uploading, confirm, done.
            state = '',
            // 所有檔案的进度信息，key为file id
            percentages = {},
            supportTransition = (function () {
                var s = document.createElement('p').style,
                    r = 'transition' in s ||
                        'WebkitTransition' in s ||
                        'MozTransition' in s ||
                        'msTransition' in s ||
                        'OTransition' in s;
                s = null;
                return r;
            })(),
            // WebUploader实例
            uploader,
            actionUrl = '/Upload.axd',
            acceptExtensions = ([".xls", ".xlsx", ".doc", ".docx",".pdf"]).join('').replace(/\./g, ',').replace(/^[,]/, ''),
            imageMaxSize = 204800000,
            imageCompressBorder = 1600;
        imageList = [];
        if (!WebUploader.Uploader.support()) {
            $('#filePickerReady').after($('<div>').html(lang.errorNotSupport)).hide();
            return;
        }

        uploader = WebUploader.create({
            pick: {
                id: '#filePickerReady',
                label: lang.uploadSelectFile
            },
            accept: {
                title: 'Images',
                extensions: acceptExtensions,
                mimeTypes: 'application/*'
            },
            swf: '/admindanny/ueditor/third-party/webuploader/Uploader.swf',
            server: actionUrl,
            fileVal: 'upfile',
            duplicate: true,
            dnd: '#upload',
            disableGlobalDnd: true,
            fileSingleSizeLimit: imageMaxSize,    // 默认 2 M
            compress: {
                width: imageCompressBorder,
                height: imageCompressBorder,
                // 圖片质量，只有type为`image/jpeg`的时候才有效。
                quality: 90,
                // 是否允许放大，如果想要生成小图的时候不失真，此選项应该设置为false.
                allowMagnify: false,
                // 是否允许裁剪。
                crop: false,
                // 是否保留头部meta信息。
                preserveHeaders: true
            }
        });
        uploader.addButton({
            id: '#filePickerBlock'
        });
        uploader.addButton({
            id: '#filePickerBtn',
            label: lang.uploadAddFile
        });

        setState('pedding');

        // 当有檔案添加进来时执行，负责view的创建
        function addFile(file) {
            var $li = $('<li id="' + file.id + '">' +
                '<p class="title">' + file.name + '</p>' +
                '<p class="imgWrap"></p>' +
                '<p class="progress"><span></span></p>' +
                '</li>'),

                $btns = $('<div class="file-panel">' +
                    '<span class="cancel">' + lang.uploadDelete + '</span>' +
                    '<span class="rotateRight">' + lang.uploadTurnRight + '</span>' +
                    '<span class="rotateLeft">' + lang.uploadTurnLeft + '</span></div>').appendTo($li),
                $prgress = $li.find('p.progress span'),
                $wrap = $li.find('p.imgWrap'),
                $info = $('<p class="error" style="left: -30px;"></p>').hide().appendTo($li),

                showError = function (code) {
                    switch (code) {
                        case 'exceed_size':
                            text = lang.errorExceedSize;
                            break;
                        case 'interrupt':
                            text = lang.errorInterrupt;
                            break;
                        case 'http':
                            text = lang.errorHttp;
                            break;
                        case 'not_allow_type':
                            text = lang.errorFileType;
                            break;
                        default:
                            text = lang.errorUploadRetry;
                            break;
                    }
                    $info.text(text).show();
                };

            if (file.getStatus() === 'invalid') {
                showError(file.statusText);
            } else {
                $wrap.text(lang.uploadPreview);
                if (browser.ie && browser.version <= 7) {
                    $wrap.text(lang.uploadNoPreview);
                } else {
                    uploader.makeThumb(file, function (error, src) {
                        if (error || !src) {
                            $wrap.text(lang.uploadNoPreview);
                        } else {
                            var $img = $('<img src="' + src + '">');
                            $wrap.empty().append($img);
                            $img.on('error', function () {
                                $wrap.text(lang.uploadNoPreview);
                            });
                        }
                    }, thumbnailWidth, thumbnailHeight);
                }
                percentages[file.id] = [file.size, 0];
                file.rotation = 0;

                /* 检查檔案格式 */
                if (!file.ext || acceptExtensions.indexOf(file.ext.toLowerCase()) == -1) {
                    showError('not_allow_type');
                    uploader.removeFile(file);
                }
            }

            file.on('statuschange', function (cur, prev) {
                if (prev === 'progress') {
                    $prgress.hide().width(0);
                } else if (prev === 'queued') {
                    $li.off('mouseenter mouseleave');
                    $btns.remove();
                }
                // 成功
                if (cur === 'error' || cur === 'invalid') {
                    showError(file.statusText);
                    percentages[file.id][1] = 1;
                } else if (cur === 'interrupt') {
                    showError('interrupt');
                } else if (cur === 'queued') {
                    percentages[file.id][1] = 0;
                } else if (cur === 'progress') {
                    $info.hide();
                    $prgress.css('display', 'block');
                } else if (cur === 'complete') {
                }

                $li.removeClass('state-' + prev).addClass('state-' + cur);
            });

            $li.on('mouseenter', function () {
                $btns.stop().animate({ height: 30 });
            });
            $li.on('mouseleave', function () {
                $btns.stop().animate({ height: 0 });
            });

            $btns.on('click', 'span', function () {
                var index = $(this).index(),
                    deg;

                switch (index) {
                    case 0:
                        uploader.removeFile(file);
                        return;
                    case 1:
                        file.rotation += 90;
                        break;
                    case 2:
                        file.rotation -= 90;
                        break;
                }

                if (supportTransition) {
                    deg = 'rotate(' + file.rotation + 'deg)';
                    $wrap.css({
                        '-webkit-transform': deg,
                        '-mos-transform': deg,
                        '-o-transform': deg,
                        'transform': deg
                    });
                } else {
                    $wrap.css('filter', 'progid:DXImageTransform.Microsoft.BasicImage(rotation=' + (~~((file.rotation / 90) % 4 + 4) % 4) + ')');
                }

            });

            $li.insertBefore($filePickerBlock);
        }

        // 负责view的销毁
        function removeFile(file) {
            var $li = $('#' + file.id);
            delete percentages[file.id];
            updateTotalProgress();
            $li.off().find('.file-panel').off().end().remove();
        }

        function updateTotalProgress() {
            var loaded = 0,
                total = 0,
                spans = $progress.children(),
                percent;

            $.each(percentages, function (k, v) {
                total += v[0];
                loaded += v[0] * v[1];
            });

            percent = total ? loaded / total : 0;

            spans.eq(0).text(Math.round(percent * 100) + '%');
            spans.eq(1).css('width', Math.round(percent * 100) + '%');
            updateStatus();
        }

        function setState(val, files) {

            if (val != state) {

                var stats = uploader.getStats();

                $upload.removeClass('state-' + state);
                $upload.addClass('state-' + val);

                switch (val) {

                    /* 未選擇檔案 */
                    case 'pedding':
                        $queue.addClass('element-invisible');
                        $statusBar.addClass('element-invisible');
                        $placeHolder.removeClass('element-invisible');
                        $progress.hide(); $info.hide();
                        uploader.refresh();
                        break;

                    /* 可以開始上傳 */
                    case 'ready':
                        $placeHolder.addClass('element-invisible');
                        $queue.removeClass('element-invisible');
                        $statusBar.removeClass('element-invisible');
                        $progress.hide(); $info.show();
                        $upload.text(lang.uploadStart);
                        uploader.refresh();
                        break;

                    /* 上傳中 */
                    case 'uploading':
                        $progress.show(); $info.hide();
                        $upload.text(lang.uploadPause);
                        break;

                    /* 暂停上傳 */
                    case 'paused':
                        $progress.show(); $info.hide();
                        $upload.text(lang.uploadContinue);
                        break;

                    case 'confirm':
                        $progress.show(); $info.hide();
                        $upload.text(lang.uploadStart);

                        stats = uploader.getStats();
                        if (stats.successNum && !stats.uploadFailNum) {
                            setState('finish');
                            return;
                        }
                        break;

                    case 'finish':
                        $progress.hide(); $info.show();
                        if (stats.uploadFailNum) {
                            $upload.text(lang.uploadRetry);
                        } else {
                            $upload.text(lang.uploadStart);
                        }
                        break;
                }

                state = val;
                updateStatus();

            }

            if (!getQueueCount()) {
                $upload.addClass('disabled')
            } else {
                $upload.removeClass('disabled')
            }

        }

        function updateStatus() {
            var text = '', stats;

            if (state === 'ready') {
                text = lang.updateStatusReady.replace('_', fileCount).replace('_KB', WebUploader.formatSize(fileSize));
            } else if (state === 'confirm') {
                stats = uploader.getStats();
                if (stats.uploadFailNum) {
                    text = lang.updateStatusConfirm.replace('_', stats.successNum).replace('_', stats.successNum);
                }
            } else {
                stats = uploader.getStats();
                text = lang.updateStatusFinish.replace('_', fileCount).
                    replace('_KB', WebUploader.formatSize(fileSize)).
                    replace('_', stats.successNum);

                if (stats.uploadFailNum) {
                    text += lang.updateStatusError.replace('_', stats.uploadFailNum);
                }
            }

            $info.html(text);
        }

        uploader.on('fileQueued', function (file) {
            fileCount++;
            fileSize += file.size;

            if (fileCount === 1) {
                $placeHolder.addClass('element-invisible');
                $statusBar.show();
            }

            addFile(file);
        });

        uploader.on('fileDequeued', function (file) {
            fileCount--;
            fileSize -= file.size;

            removeFile(file);
            updateTotalProgress();
        });

        uploader.on('filesQueued', function (file) {
            if (!uploader.isInProgress() && (state == 'pedding' || state == 'finish' || state == 'confirm' || state == 'ready')) {
                setState('ready');
            }
            updateTotalProgress();
        });

        uploader.on('all', function (type, files) {
            switch (type) {
                case 'uploadFinished':
                    setState('confirm', files);
                    break;
                case 'startUpload':
                    /* 添加额外的GET参数 */
                    var params = '',
                        url = "/admindanny/ueditor/net/controller.ashx?action=fileUpload";
                    uploader.option('server', url);
                    setState('uploading', files);
                    break;
                case 'stopUpload':
                    setState('paused', files);
                    break;
            }
        });

        uploader.on('uploadBeforeSend', function (file, data, header) {
            //这里可以通过data对象添加POST参数
            header['X_Requested_With'] = 'XMLHttpRequest';
        });

        uploader.on('uploadProgress', function (file, percentage) {
            var $li = $('#' + file.id),
                $percent = $li.find('.progress span');

            $percent.css('width', percentage * 100 + '%');
            percentages[file.id][1] = percentage;
            updateTotalProgress();
        });

        uploader.on('uploadSuccess', function (file, ret) {
            var $file = $('#' + file.id);
            try {
                var responseText = (ret._raw || ret),
                    json = JSON.parse(responseText);
                if (json.state == 'SUCCESS') {
                    _this.imageList.push(json);
                    $file.append('<span class="success" style="background-color: white;left: -20px;height: 20px;">上傳成功</span>');
                } else {
                    $file.find('.error').text(json.state).show();
                }
            } catch (e) {
                $file.find('.error').text(lang.errorServerUpload).show();
            }
        });

        uploader.on('uploadError', function (file, code) {
        });
        uploader.on('error', function (code, file) {
            if (code == 'Q_TYPE_DENIED' || code == 'F_EXCEED_SIZE') {
                addFile(file);
            }
        });
        uploader.on('uploadComplete', function (file, ret) {
        });

        $upload.on('click', function () {
            if ($(this).hasClass('disabled')) {
                return false;
            }

            if (state === 'ready') {
                uploader.upload();
            } else if (state === 'paused') {
                uploader.upload();
            } else if (state === 'uploading') {
                uploader.stop();
            }
        });

        $upload.addClass('state-' + state);
        updateTotalProgress();

        function getQueueCount() {
            var file, i, status, readyFile = 0, files = uploader.getFiles();
            for (i = 0; file = files[i++];) {
                status = file.getStatus();
                if (status == 'queued' || status == 'uploading' || status == 'progress') readyFile++;
            }
            return readyFile;
        }
    }


    initUploader();
</script>
</html>
