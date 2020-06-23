S/W Version Information
Model: SM-R365
Tizen-Version: 2.3.1.13
Build-Number: R365XXU2CRC7
Build-Date: 2018.03.27 20:26:45

Crash Information
Process Name: sensorapp
PID: 3956
Date: 2020-03-05 09:48:14+0900
Executable File Path: /opt/usr/apps/org.example.sensorapp/bin/sensorapp
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 3956, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xbe8f7ce0
r2   = 0x42e93884, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x00000000
r6   = 0x00010000, r7   = 0x000000a2
r8   = 0xbe8f7ce0, r9   = 0x403b0824
r10  = 0x42efe470, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe8f7b48
lr   = 0x40510bd0, pc   = 0x404d3484
cpsr = 0x80000010

Memory Information
MemTotal:   492008 KB
MemFree:     41404 KB
Buffers:     33672 KB
Cached:     181680 KB
VmPeak:     116372 KB
VmSize:     115360 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18272 KB
VmRSS:       18268 KB
VmData:      56920 KB
VmStk:         136 KB
VmExe:          16 KB
VmLib:       26320 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 3956 TID = 3956
3956 3965 3966 3967 4020 4021 

Maps Information
40000000 40004000 r-xp /opt/usr/apps/org.example.sensorapp/bin/sensorapp
40006000 4000a000 r-xp /usr/lib/libsys-assert.so
40015000 40032000 r-xp /lib/ld-2.13.so
4003c000 4003f000 rw-p [stack:3966]
4003f000 40044000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4004e000 40052000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005a000 4005e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
40067000 40069000 r-xp /usr/lib/libdlog.so.0.0.0
40071000 40092000 r-xp /usr/lib/libefl-extension.so.0.1.0
4009b000 401d5000 r-xp /usr/lib/libelementary.so.1.7.99
401ec000 402ba000 r-xp /usr/lib/libevas.so.1.7.99
402e0000 403b0000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
403b1000 403c4000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
403cd000 40436000 r-xp /lib/libm-2.13.so
4043f000 4055a000 r-xp /lib/libc-2.13.so
40568000 40570000 r-xp /lib/libgcc_s-4.6.so.1
40571000 4057c000 r-xp /lib/libunwind.so.8.0.1
405a9000 405ab000 r-xp /lib/libdl-2.13.so
405b4000 405b8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
405c1000 405c3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
405cc000 405d1000 r-xp /usr/lib/libappcore-efl.so.1.1
405d9000 405de000 r-xp /usr/lib/libappcore-common.so.1.1
405e6000 405f2000 r-xp /usr/lib/libaul.so.0.1.0
405fc000 4061f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40627000 40668000 r-xp /usr/lib/libeina.so.1.7.99
40671000 40685000 r-xp /lib/libpthread-2.13.so
40690000 406ba000 r-xp /usr/lib/libsensor.so.2.3.4
406c3000 40757000 r-xp /usr/lib/libstdc++.so.6.0.16
4076a000 407ba000 r-xp /usr/lib/libecore_x.so.1.7.99
407bc000 407d3000 r-xp /usr/lib/libecore.so.1.7.99
407ea000 40848000 r-xp /usr/lib/libedje.so.1.7.99
40851000 40909000 r-xp /usr/lib/libcairo.so.2.11200.14
40914000 409f5000 r-xp /usr/lib/libX11.so.6.3.0
40a00000 40a09000 r-xp /usr/lib/libXi.so.6.1.0
40a11000 40a39000 r-xp /usr/lib/libfontconfig.so.1.8.0
40a3a000 40a53000 r-xp /usr/lib/libeet.so.1.7.99
40a64000 40a86000 r-xp /usr/lib/libecore_evas.so.1.7.99
40a8f000 40a94000 r-xp /usr/lib/libecore_file.so.1.7.99
40a9c000 40aad000 r-xp /usr/lib/libecore_input.so.1.7.99
40ab5000 40abe000 r-xp /usr/lib/libvconf.so.0.2.45
40ac6000 40acf000 r-xp /usr/lib/libedbus.so.1.7.99
40ad7000 40b01000 r-xp /usr/lib/libdbus-1.so.3.8.12
40b0a000 40b24000 r-xp /usr/lib/libecore_con.so.1.7.99
40b2d000 40b40000 r-xp /usr/lib/libfribidi.so.0.3.1
40b48000 40b85000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40b8e000 40be4000 r-xp /usr/lib/libfreetype.so.6.11.3
40bf0000 40c46000 r-xp /usr/lib/libpixman-1.so.0.28.2
40c53000 40c59000 r-xp /lib/librt-2.13.so
40c62000 40d35000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40d40000 40d48000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
40d50000 40d56000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
40d5f000 40d64000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
40d6c000 40da0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40da9000 40db2000 r-xp /usr/lib/libsap_client.so.0.0.0
40dba000 40dc0000 r-xp /usr/lib/libappsvc.so.0.1.0
40dc8000 40dcb000 r-xp /usr/lib/libbundle.so.0.1.22
40dd3000 40dd9000 r-xp /usr/lib/libecore_imf.so.1.7.99
40de2000 40de4000 r-xp /usr/lib/libiniparser.so.0
40ded000 40e04000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40e0c000 40e11000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e19000 40e55000 r-xp /usr/lib/libsystemd.so.0.4.0
40e5e000 40e62000 r-xp /usr/lib/libproc-stat.so.0.2.86
40e6c000 40e82000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40e8b000 40f00000 r-xp /usr/lib/libsqlite3.so.0.8.6
40f0a000 40f10000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
40f19000 40f23000 r-xp /usr/lib/libsensord-shared.so
40f2c000 40f33000 r-xp /usr/lib/libXcursor.so.1.0.2
40f3c000 40f3e000 r-xp /usr/lib/libXdamage.so.1.1.0
40f46000 40f48000 r-xp /usr/lib/libXcomposite.so.1.0.0
40f50000 40f52000 r-xp /usr/lib/libXgesture.so.7.0.0
40f5a000 40f5d000 r-xp /usr/lib/libXfixes.so.3.1.0
40f65000 40f66000 r-xp /usr/lib/libXinerama.so.1.0.0
40f6f000 40f75000 r-xp /usr/lib/libXrandr.so.2.2.0
40f7e000 40f84000 r-xp /usr/lib/libXrender.so.1.3.0
40f8c000 40f90000 r-xp /usr/lib/libXtst.so.6.1.0
40f98000 40fa2000 r-xp /usr/lib/libXext.so.6.4.0
40fab000 40fb2000 r-xp /usr/lib/libembryo.so.1.7.99
40fba000 40fd1000 r-xp /usr/lib/liblua-5.1.so
40fdb000 40fdc000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40fe4000 40ff2000 r-xp /usr/lib/libGLESv2.so.2.0
40ffb000 41013000 r-xp /usr/lib/libpng12.so.0.50.0
4101b000 4101c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41025000 4102b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41034000 41047000 r-xp /usr/lib/libxcb.so.1.1.0
41050000 41066000 r-xp /lib/libz.so.1.2.5
4106e000 41071000 r-xp /usr/lib/libEGL.so.1.4
41079000 4108f000 r-xp /lib/libexpat.so.1.5.2
41099000 410bc000 r-xp /usr/lib/libjpeg.so.8.0.2
410d5000 410da000 r-xp /usr/lib/libecore_fb.so.1.7.99
410e3000 410e7000 r-xp /usr/lib/libecore_ipc.so.1.7.99
410f0000 410f3000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
410fb000 4113f000 r-xp /usr/lib/libcurl.so.4.3.0
41149000 4114a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41152000 41157000 r-xp /usr/lib/libffi.so.5.0.10
4115f000 41161000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41169000 41179000 r-xp /lib/libresolv-2.13.so
4117d000 41199000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
411a3000 411a7000 r-xp /usr/lib/libsmack.so.1.0.0
411b0000 4127c000 r-xp /usr/lib/libxml2.so.2.7.8
41289000 412a1000 r-xp /usr/lib/liblzma.so.5.0.3
412a9000 41325000 r-xp /usr/lib/libgcrypt.so.20.0.3
41332000 41334000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
4133d000 4133f000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41347000 41349000 r-xp /usr/lib/libXau.so.6.0.0
41352000 4135b000 r-xp /usr/lib/libcares.so.2.1.0
41364000 41392000 r-xp /usr/lib/libidn.so.11.5.44
4139a000 413e1000 r-xp /usr/lib/libssl.so.1.0.0
413ed000 41596000 r-xp /usr/lib/libcrypto.so.1.0.0
415b7000 415be000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
415c8000 415ca000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
415d2000 41600000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
41609000 41610000 r-xp /usr/lib/libminizip.so.1.0.0
41618000 41625000 r-xp /usr/lib/libail.so.0.1.0
4162e000 4176b000 r-xp /usr/lib/libicui18n.so.51.1
4177c000 41860000 r-xp /usr/lib/libicuuc.so.51.1
42dff000 42e0a000 r-xp /usr/lib/libgpg-error.so.0.15.0
42e12000 42e2f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
42e39000 42e3b000 r-xp /usr/lib/libiri.so
42e43000 42e46000 r-xp /lib/libcap.so.2.21
42e4e000 42e55000 r-xp /lib/libcrypt-2.13.so
42e85000 42e88000 r-xp /lib/libattr.so.1.1.0
42f96000 43060000 r-xp /usr/lib/libCOREGL.so.4.0
43072000 43096000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4309f000 4316e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43184000 4318e000 r-xp /lib/libnss_files-2.13.so
434c8000 4353f000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
4354f000 4355a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43563000 436ab000 r-xp /usr/lib/egl/libMali.so
436b0000 436b2000 r-xp /usr/lib/libdri2.so.0.0.0
436ba000 436c2000 r-xp /usr/lib/libdrm.so.2.4.0
436ca000 436d1000 r-xp /usr/lib/libtbm.so.1.0.0
436d9000 436dc000 r-xp /usr/lib/libnative-buffer.so.0.1.0
436e5000 43ee4000 rw-p [stack:3965]
44084000 44085000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44236000 44a35000 rw-p [stack:3967]
44b29000 44b2c000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
44b34000 44b35000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44b50000 44b57000 r-xp /usr/lib/libfeedback.so.0.1.4
44b60000 44b61000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44b69000 44b6b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44b73000 44b7d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
44b85000 44b88000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44c90000 44c91000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
44c99000 44ca0000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44ca8000 44cbe000 r-xp /usr/lib/libmmfsound.so.0.1.0
44cd0000 44cd5000 r-xp /usr/lib/libmmfsession.so.0.0.0
44cdd000 44ce7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44cf3000 44cf7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44d00000 44d15000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44d1d000 44d7e000 r-xp /usr/lib/libasound.so.2.0.0
44d88000 44dc0000 r-xp /usr/lib/libpulse.so.0.16.2
44dc1000 44dc4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44dcc000 44dfd000 r-xp /usr/lib/libmdm.so.1.1.86
44e05000 44e0a000 r-xp /usr/lib/libjson.so.0.0.1
44e12000 44e5a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44e5b000 44ea2000 r-xp /usr/lib/libsndfile.so.1.0.26
44eae000 44eb6000 r-xp /usr/lib/libmdm-common.so.1.0.89
44eb7000 44ed9000 r-xp /usr/lib/libvorbis.so.0.4.3
44ee1000 44ee5000 r-xp /usr/lib/libogg.so.0.7.1
44eee000 456ed000 rw-p [stack:4020]
456ee000 45eed000 rw-p [stack:4021]
be8d8000 be8f9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3956)
Call Stack Count: 17
 0: nanosleep + 0x44 (0x404d3484) [/lib/libc.so.6] + 0x94484
 1: sleep + 0xd0 (0x404d3244) [/lib/libc.so.6] + 0x94244
 2: on_data_received + 0x1ba (0x400035d3) [/opt/usr/apps/org.example.sensorapp/bin/sensorapp] + 0x35d3
 3: on_sensor_event + 0x142 (0x40001c73) [/opt/usr/apps/org.example.sensorapp/bin/sensorapp] + 0x1c73
 4: (0x4005be67) [/usr/lib/libcapi-system-sensor.so.0] + 0x1e67
 5: (0x4069f078) [/usr/lib/libsensor.so.2] + 0xf078
 6: (0x40313fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 7: g_main_context_dispatch + 0xbc (0x403157a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 8: (0x407ccca7) [/usr/lib/libecore.so.1] + 0x10ca7
 9: (0x407c7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
10: (0x407c85a7) [/usr/lib/libecore.so.1] + 0xc5a7
11: ecore_main_loop_begin + 0x30 (0x407c8879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x20a (0x405cf523) [/usr/lib/libappcore-efl.so.1] + 0x3523
13: ui_app_main + 0xb0 (0x40050421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x54 (0x400031f5) [/opt/usr/apps/org.example.sensorapp/bin/sensorapp] + 0x31f5
15: __libc_start_main + 0x114 (0x4045682c) [/lib/libc.so.6] + 0x1782c
16: (0x4000190c) [/opt/usr/apps/org.example.sensorapp/bin/sensorapp] + 0x190c
End of Call Stack

Package Information
Package Name: org.example.sensorapp
Package ID : org.example.sensorapp
Version: 1.1.0
Package Type: rpm
App Name: sensorapp
App ID: org.example.sensorapp
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
irectly
03-05 09:48:05.000+0900 E/EFL     (  800): ecore_x<800> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=624714
03-05 09:48:05.010+0900 W/STARTER (  722): hw_key.c: _powerkey_timer_cb(884) > [_powerkey_timer_cb:884] _powerkey_timer_cb, powerkey count[1]
03-05 09:48:05.010+0900 W/STARTER (  722): hw_key.c: _powerkey_timer_cb(1106) > [_powerkey_timer_cb:1106] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
03-05 09:48:05.010+0900 E/STARTER (  722): dbus-util.c: dbus_request_cpu_boost(376) > [dbus_request_cpu_boost:376] failed to _invoke_dbus_method_sync
03-05 09:48:05.010+0900 W/AUL     (  722): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
03-05 09:48:05.010+0900 W/AUL_AMD (  547): amd_request.c: __request_handler(645) > __request_handler: 0
03-05 09:48:05.015+0900 W/AUL_AMD (  547): amd_launch.c: _start_app(1713) > caller pid : 722
03-05 09:48:05.020+0900 W/AUL_AMD (  547): amd_launch.c: __nofork_processing(1155) > __nofork_processing, cmd: 0, pid: 800
03-05 09:48:05.020+0900 I/APP_CORE(  800): appcore-efl.c: __do_app(429) > [APP 800] Event: RESET State: RUNNING
03-05 09:48:05.020+0900 I/CAPI_APPFW_APPLICATION(  800): app_main.c: app_appcore_reset(245) > app_appcore_reset
03-05 09:48:05.020+0900 W/W_HOME  (  800): main.c: _app_control(1739) > Service value : powerkey
03-05 09:48:05.020+0900 W/CAPI_APPFW_APP_CONTROL(  800): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-05 09:48:05.020+0900 I/wnotib  (  800): w-notification-board-broker-main.c: _wnb_view_event_handler(865) > Home view event: 0x40001
03-05 09:48:05.020+0900 I/wnotib  (  800): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(859) > 
03-05 09:48:05.020+0900 W/W_HOME  (  800): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
03-05 09:48:05.020+0900 E/W_HOME  (  800): cs_broker.c: _cs_broker_home_cb(259) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
03-05 09:48:05.020+0900 W/W_HOME  (  800): main.c: _home_key_cb(1653) > Home Key operation tutorial:0 window:1 clock:1 apps:0
03-05 09:48:05.020+0900 W/W_HOME  (  800): cs_broker.c: cs_borker_is_created(457) > created:0
03-05 09:48:05.020+0900 W/W_HOME  (  800): move.c: move_move_to_apps(220) > move to apps
03-05 09:48:05.020+0900 W/W_HOME  (  800): move.c: _create_fake_apps(823) > fake image position : 432
03-05 09:48:05.025+0900 W/AUL_AMD (  547): amd_launch.c: __reply_handler(925) > listen fd(23) , send fd(22), pid(800), cmd(0)
03-05 09:48:05.025+0900 W/AUL     (  722): launch.c: app_request_to_launchpad(282) > request cmd(0) result(800)
03-05 09:48:05.025+0900 W/W_HOME  (  800): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
03-05 09:48:05.025+0900 W/W_HOME  (  800): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
03-05 09:48:05.025+0900 W/W_HOME  (  800): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-05 09:48:05.025+0900 W/W_HOME  (  800): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-05 09:48:05.025+0900 I/APP_CORE(  800): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
03-05 09:48:05.030+0900 W/W_HOME  (  800): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
03-05 09:48:05.030+0900 W/W_HOME  (  800): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
03-05 09:48:05.030+0900 W/W_HOME  (  800): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-05 09:48:05.030+0900 W/W_HOME  (  800): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-05 09:48:05.030+0900 W/W_HOME  (  800): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-05 09:48:05.030+0900 W/W_HOME  (  800): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
03-05 09:48:05.030+0900 W/W_HOME  (  800): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
03-05 09:48:05.030+0900 I/wnotib  (  800): w-notification-board-broker-main.c: _wnb_view_event_handler(865) > Home view event: 0x80002
03-05 09:48:05.030+0900 I/wnotib  (  800): w-notification-board-broker-main.c: _wnb_view_event_handler(904) > Unhandled type: 0x80002
03-05 09:48:05.065+0900 E/AUL     (  722): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
03-05 09:48:05.065+0900 E/AUL     (  547): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
03-05 09:48:05.080+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
03-05 09:48:05.080+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
03-05 09:48:05.085+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
03-05 09:48:05.090+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
03-05 09:48:05.090+0900 E/EFL     ( 4108): elementary<4108> elm_config.c:2747 _elm_config_init() _elm_config_init step 1 done.
03-05 09:48:05.105+0900 E/EFL     ( 4108): elementary<4108> elm_config.c:2755 _elm_config_init() _elm_config_init step 2 done.
03-05 09:48:05.110+0900 E/EFL     ( 4108): elementary<4108> elm_config.c:2759 _elm_config_init() _elm_config_init step 3 done.
03-05 09:48:05.110+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
03-05 09:48:05.140+0900 E/EFL     ( 4108): elementary<4108> elm_config.c:2799 _elm_config_sub_init() ecore_x_init done.
03-05 09:48:05.150+0900 E/EFL     ( 4108): elementary<4108> elm_config.c:2854 _elm_config_sub_init() _config_sub_apply done.
03-05 09:48:05.150+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
03-05 09:48:05.150+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
03-05 09:48:05.150+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
03-05 09:48:05.150+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
03-05 09:48:05.150+0900 E/EFL     ( 4108): elementary<4108> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
03-05 09:48:05.150+0900 I/AUL_PAD ( 4108): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-05 09:48:05.275+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-05 09:48:05.275+0900 E/CAPI_APPFW_APP_CONTROL( 1116): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
03-05 09:48:05.275+0900 W/MUSIC_CONTROL_SERVICE( 1116): music-control-service.c: _music_control_service_pasre_request(489) > [33m[TID:1116]   [com.samsung.w-home]register msg port [true][0m
03-05 09:48:05.280+0900 W/AUL_AMD (  547): amd_request.c: __request_handler(645) > __request_handler: 14
03-05 09:48:05.285+0900 W/AUL_AMD (  547): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 800
03-05 09:48:05.290+0900 W/MUSIC_CONTROL_SERVICE( 1116): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1116]   [MUSIC_PLAYER_EVENT][0m
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-05 09:48:05.295+0900 W/MUSIC_CONTROL_SERVICE( 1116): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1116]   [MUSIC_PLAYER_EVENT][0m
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-05 09:48:05.295+0900 I/MESSAGE_PORT(  515): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-05 09:48:05.300+0900 W/W_HOME  (  800): clock_shortcut.c: _music_service_messageport_cb(372) > mode:remote state:paused 
03-05 09:48:05.300+0900 E/W_HOME  (  800): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-05 09:48:05.300+0900 W/W_HOME  (  800): clock_shortcut.c: _music_service_messageport_cb(372) > mode:remote state:paused 
03-05 09:48:05.300+0900 E/W_HOME  (  800): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-05 09:48:05.330+0900 W/W_HOME  (  800): move.c: _transit_del_cb(115) > transit end
03-05 09:48:05.330+0900 W/W_HOME  (  800): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
03-05 09:48:05.330+0900 W/W_HOME  (  800): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-05 09:48:05.340+0900 W/W_HOME  (  800): move.c: _scroller_up_done(515) > up signal done
03-05 09:48:05.345+0900 W/W_HOME  (  800): event_manager.c: _apptray_visibility_cb(583) > apps,show
03-05 09:48:05.350+0900 W/W_HOME  (  800): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
03-05 09:48:05.350+0900 W/W_HOME  (  800): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-05 09:48:05.350+0900 W/W_HOME  (  800): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-05 09:48:05.350+0900 W/W_HOME  (  800): main.c: home_pause(765) > clock/widget paused
03-05 09:48:05.350+0900 W/W_HOME  (  800): clock_indicator.c: clock_indicator_pause(565) > 
03-05 09:48:05.350+0900 W/W_HOME  (  800): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-05 09:48:05.350+0900 W/APPS    (  800): apps_main.c: _time_changed(303) >  date : 5->5
03-05 09:48:05.350+0900 W/W_HOME  (  800): noti_broker.c: _apptray_visibility_cb(789) > apps,show
03-05 09:48:05.350+0900 W/W_HOME  (  800): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
03-05 09:48:05.350+0900 I/wnotib  (  800): w-notification-board-broker-main.c: _wnb_view_event_handler(865) > Home view event: 0x80000
03-05 09:48:05.350+0900 I/wnotib  (  800): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1482) > is_app_tray_displayed: 1
03-05 09:48:05.350+0900 E/APPS    (  800): apps_main.c: apps_main_resume(682) >  resumed already
03-05 09:48:05.365+0900 W/WATCH_CORE(  838): appcore-watch.c: __widget_pause(1028) > widget_pause
03-05 09:48:05.365+0900 E/watchface-loader(  838): watchface-loader.cpp: OnAppPause(646) > 
03-05 09:48:05.370+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
03-05 09:48:05.370+0900 W/HealthDataService(  807): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:SHealthDataListenerList|BQssJz8fDSo7BAx6JRwzGCA+JwYFEywxIysCXSIiHBsgVRdMOzkuMjMcPB0DNCwLLj4/CSAsKCQ0LxEbDyAZACoxJwELRiknMypxDTUfOwArG1geBS8jAy8mAigKKCw1NC4bLi4vCSMsCiQ0KzQgLyYHJicjIiggESwjDwwPLwckBz4xLjk8CwM4PC8mCigzKCx/SA==[0;m
03-05 09:48:05.375+0900 W/HealthDataService(  807): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[SHealthDataListenerList : com.samsung.shealth-service][0;m
03-05 09:48:05.380+0900 W/LibServiceCommon( 1137): SHealthDataShareManager.cpp: SetPedometerClientRefCount(1624) > [1;40;33mPedo client Ref Count [0][0;m
03-05 09:48:05.380+0900 W/LibServiceCommon( 1137): SHealthDataShareManager.cpp: SetHeartRateClientRefCount(1646) > [1;40;33mHR client Ref Count [0][0;m
03-05 09:48:05.385+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
03-05 09:48:05.385+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
03-05 09:48:05.385+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
03-05 09:48:05.385+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
03-05 09:48:05.385+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
03-05 09:48:05.385+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
03-05 09:48:05.385+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1137): preference.c: _preference_check_retry_err(507) > key(lastest_continous_hr), check retry err: -21/(2/No such file or directory).
03-05 09:48:05.385+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1137): preference.c: _preference_get_key(1101) > _preference_get_key(lastest_continous_hr) step(-17825744) failed(2 / No such file or directory)
03-05 09:48:05.385+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1137): preference.c: preference_get_string(1258) > preference_get_string(1137) : lastest_continous_hr error
03-05 09:48:05.385+0900 W/WSLibCore( 1137): JsonSerializeManipulator.cpp: DeserializeThrowException(225) > [1;40;33mIt's not json serialized string[0;m
03-05 09:48:05.385+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
03-05 09:48:05.385+0900 W/WSLibCore( 1137): Message.cpp: Get(268) > [1;40;33mIt doesn't have key with name (heart_rate)[0;m
03-05 09:48:05.385+0900 W/WSLibCore( 1137): Message.cpp: Get(268) > [1;40;33mIt doesn't have key with name (time_offset)[0;m
03-05 09:48:05.385+0900 W/WSLibCore( 1137): Message.cpp: Get(268) > [1;40;33mIt doesn't have key with name (time_stamp)[0;m
03-05 09:48:05.390+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(164) > [1;40;33mNo record[0;m
03-05 09:48:05.390+0900 W/SHealthCommon( 1137): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
03-05 09:48:05.395+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(164) > [1;40;33mNo record[0;m
03-05 09:48:05.395+0900 W/SHealthCommon( 1137): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
03-05 09:48:05.400+0900 W/SHealthCommon( 1137): SHealthMessagePortConnection.cpp: SendServiceMessage(557) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
03-05 09:48:05.400+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
03-05 09:48:05.410+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
03-05 09:48:05.410+0900 W/HealthDataService(  807): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BSYreD8hCSQ4BAR8JSIjGDcpIwcSEwowIBUCHiMMMhg3MxQRLFw9IyQxOBUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIPCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIjLyYOKQw8DSECNBEKKCwJOD4WKC0JQyAvJgANLzkhMQ0TIwEYM1R6DjhfJCAsHiQ0LxIZIDMoEgUTOF4dMSJ+JjkJTCMtKBsFMyAZKgM4Bi8mCigKODwDNC8tLi4vChg0HCsZDD0zCAR9PiIbR1s4LVkjBTQQM18kBCp4LTAvIgM4NC8qHyx+KCgTNCwLLi0sCSAvAxI0LxIpJAsWWh4MEShqDzEcJxsqFD0hCCQCEQM5MSoaRjgeET4ZDwkFGRkQPi44CSAvCighO2csFC41JgwoDCEHHhwEKlk/NCsGHiEMNiAkAAM4NC8iDigKKDgDNCwLNSgoOAMmJwMXOT8UNlUnBBEhP14wGC17MzwJOi4GKC0FNiADJgM4NC82GigKKzwDNCwIBDY5JBILHVwBNwsJCAYIPiAaGzwqLDMZBSwJMC4GKC0/NiBTWg==[0;m
03-05 09:48:05.415+0900 W/HealthDataService(  807): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[shealth_heartrate : com.samsung.watchface][0;m
03-05 09:48:05.415+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
03-05 09:48:05.420+0900 I/healthData( 1137): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
03-05 09:48:05.420+0900 W/SHealthCommon( 1137): SHealthMessagePortConnection.cpp: SendServiceMessage(557) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
03-05 09:48:05.425+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
03-05 09:48:05.435+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
03-05 09:48:05.445+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
03-05 09:48:05.450+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
03-05 09:48:05.450+0900 W/HealthDataService(  807): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:SHealthDataListenerList|BVMjMSoiI2cvOj57JTIjGTQ5PBESPSckNisNACEiJlQhIwQRLyoEeDMmLB0DNCwLLj4/CSAsKCQ0LxEbDyAZACoxJwELRiknMypxDTUfOwArG1geBS8jAy8mAigKKCw1NC4bLi4vCSMsCiQ0KzQgLyYHJicjIiggESwjDwwPLwckBz4xLjk8CwM4PC8mCig8KCx/SA==[0;m
03-05 09:48:05.455+0900 W/HealthDataService(  807): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[SHealthDataListenerList : com.samsung.shealth-service][0;m
03-05 09:48:05.460+0900 W/healthData( 1137): health_fw_share.c: __health_notify_share_cb(333) > [1;40;33mNotification is called [category:SHealthDataListenerList][0;m
03-05 09:48:05.460+0900 W/LibServiceCommon( 1137): SHealthDataShareManager.cpp: SetPedometerClientRefCount(1624) > [1;40;33mPedo client Ref Count [0][0;m
03-05 09:48:05.460+0900 W/LibServiceCommon( 1137): SHealthDataShareManager.cpp: SetHeartRateClientRefCount(1646) > [1;40;33mHR client Ref Count [0][0;m
03-05 09:48:05.465+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
03-05 09:48:05.465+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
03-05 09:48:05.465+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
03-05 09:48:05.465+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
03-05 09:48:05.465+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
03-05 09:48:05.465+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
03-05 09:48:05.465+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
03-05 09:48:05.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1137): preference.c: _preference_check_retry_err(507) > key(lastest_continous_hr), check retry err: -21/(2/No such file or directory).
03-05 09:48:05.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1137): preference.c: _preference_get_key(1101) > _preference_get_key(lastest_continous_hr) step(-17825744) failed(2 / No such file or directory)
03-05 09:48:05.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1137): preference.c: preference_get_string(1258) > preference_get_string(1137) : lastest_continous_hr error
03-05 09:48:05.465+0900 W/WSLibCore( 1137): JsonSerializeManipulator.cpp: DeserializeThrowException(225) > [1;40;33mIt's not json serialized string[0;m
03-05 09:48:05.470+0900 W/WSLibCore( 1137): Message.cpp: Get(268) > [1;40;33mIt doesn't have key with name (heart_rate)[0;m
03-05 09:48:05.470+0900 W/WSLibCore( 1137): Message.cpp: Get(268) > [1;40;33mIt doesn't have key with name (time_offset)[0;m
03-05 09:48:05.470+0900 W/WSLibCore( 1137): Message.cpp: Get(268) > [1;40;33mIt doesn't have key with name (time_stamp)[0;m
03-05 09:48:05.470+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(164) > [1;40;33mNo record[0;m
03-05 09:48:05.470+0900 W/SHealthCommon( 1137): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
03-05 09:48:05.475+0900 W/SHealthCommon( 1137): HeartRateStorage.cpp: ExecuteSelectQuery(164) > [1;40;33mNo record[0;m
03-05 09:48:05.475+0900 W/SHealthCommon( 1137): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
03-05 09:48:05.475+0900 W/SHealthCommon( 1137): SHealthMessagePortConnection.cpp: SendServiceMessage(557) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
03-05 09:48:05.480+0900 I/HealthDataService(  807): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
03-05 09:48:05.480+0900 W/HealthDataService(  807): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BSYreD8hCSQ4BAR8JSIjGDcpIwcSEwowIBUCHiMMMhg3MxQRLFw9IyQxOBUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIPCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIjLyYOKQw8DSECNBEKKCwJOD4WKC0JQyAvJgANLzkhMQ0TIwEYM1R6DjhfJCAsHiQ0LxIZIDMoEgUTOF4dMSJ+JjkJTCMtKBsFMyAZKgM4Bi8mCigKODwDNC8tLi4vChg0HCsZDD0zCAR9PiIbR1s4LVkjBTQQM18kBCp4LTAvIgM4NC8qHyx+KCgTNCwLLi0sCSAvAxI0LxIpJAsWWh4MEShqDzEcJxsqFD0hCCQCEQM5MSoaRjgeET4ZDwkFGRkQPi44CSAvCighO2csFC41JgwoDCEHHhwEKlk/NCsGHiEMNiAkAAM4NC8iDigKKDgDNCwLNSgoOAMmJwMXOT8UNlUnBBEhP14wGC17MzwJOi4GKC0FNiADJgM4NC82GigKKzwDNCwIBDY5JBILHVwBNwsJCAYIPiAaGzwqLDMZBSwJMC4GKC0/NiBTWg==[0;m
03-05 09:48:05.490+0900 I/healthData( 1137): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
03-05 09:48:05.490+0900 W/SHealthCommon( 1137): SHealthMessagePortConnection.cpp: SendServiceMessage(557) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
03-05 09:48:05.780+0900 W/CRASH_MANAGER( 1335): worker.c: worker_job(1205) > 06040706770731583369285
03-05 09:48:05.980+0900 E/lhd     (  503): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
03-05 09:48:06.020+0900 W/AUL_AMD (  547): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
03-05 09:48:06.020+0900 W/AUL_AMD (  547): amd_launch.c: __grab_timeout_handler(1379) > back key ungrab error
03-05 09:48:06.265+0900 W/AUL_AMD (  547): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
03-05 09:48:06.645+0900 E/EFL     (  800): ecore_x<800> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=626362 button=1
03-05 09:48:06.645+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:06.650+0900 E/W_HOME  (  800): move.c: _mouse_down_cb(384) > apps move is not allowed
03-05 09:48:06.650+0900 W/APPS    (  800): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,242,216,124]
03-05 09:48:06.660+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:06.670+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:06.670+0900 W/APPS    (  800): AppsViewList.cpp: onTouchEventCancel(674) >  touch cancel
03-05 09:48:06.685+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:06.705+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:06.725+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:06.755+0900 E/EFL     (  800): ecore_x<800> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=626454 button=1
03-05 09:48:06.755+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:06.760+0900 E/APPS    (  800): AppsViewList.cpp: _scrollerMouseUp(950) >  (__bTouchCanceled) -> _scrollerMouseUp() return
03-05 09:48:07.265+0900 E/RESOURCED(  549): procfs.c: proc_get_oom_score_adj(162) > fopen /proc/4117/oom_score_adj failed
03-05 09:48:07.265+0900 E/RESOURCED(  549): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 4117
03-05 09:48:07.820+0900 E/lhd     (  503): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
03-05 09:48:08.385+0900 E/EFL     (  800): ecore_x<800> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=628100 button=1
03-05 09:48:08.385+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:08.385+0900 E/W_HOME  (  800): move.c: _mouse_down_cb(384) > apps move is not allowed
03-05 09:48:08.390+0900 W/APPS    (  800): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,329,216,136]
03-05 09:48:08.395+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:08.405+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:08.410+0900 W/APPS    (  800): AppsViewList.cpp: onTouchEventCancel(674) >  touch cancel
03-05 09:48:08.420+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:08.435+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:08.450+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:08.470+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:08.485+0900 E/EFL     (  800): ecore_x<800> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=628189 button=1
03-05 09:48:08.490+0900 E/APPS    (  800): AppsViewList.cpp: _scrollerMouseUp(950) >  (__bTouchCanceled) -> _scrollerMouseUp() return
03-05 09:48:08.995+0900 E/EFL     (  800): ecore_x<800> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=628712 button=1
03-05 09:48:08.995+0900 E/W_HOME  (  800): move.c: _mouse_move_cb(546) > apps move is not allowed
03-05 09:48:08.995+0900 E/W_HOME  (  800): move.c: _mouse_down_cb(384) > apps move is not allowed
03-05 09:48:09.000+0900 W/APPS    (  800): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,290,216,136]
03-05 09:48:09.035+0900 E/EFL     (  800): ecore_x<800> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=628751 button=1
03-05 09:48:09.035+0900 W/APPS    (  800): AppsItem.cpp: onItemClicked(444) >  onItemClicked[0,18]
03-05 09:48:09.035+0900 E/APPS    (  800): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-05 09:48:09.035+0900 W/APPS    (  800): AppsItem.cpp: onItemClicked(456) >  item(sensorapp) launched, open(0)
03-05 09:48:09.035+0900 W/AUL     (  800): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.sensorapp)
03-05 09:48:09.040+0900 W/AUL_AMD (  547): amd_request.c: __request_handler(645) > __request_handler: 0
03-05 09:48:09.040+0900 W/AUL_AMD (  547): amd_launch.c: _start_app(1713) > caller pid : 800
03-05 09:48:09.040+0900 I/AUL_AMD (  547): amd_launch.c: __check_app_control_privilege(1602) > Skip the privilege check in case of preloaded apps
03-05 09:48:09.055+0900 W/AUL_AMD (  547): amd_launch.c: __nofork_processing(1155) > __nofork_processing, cmd: 0, pid: 3956
03-05 09:48:09.060+0900 E/AUL     (  547): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
03-05 09:48:09.835+0900 E/EFL     (  547): ecore_x<547> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=629544 button=1
03-05 09:48:09.905+0900 E/EFL     (  547): ecore_x<547> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=629623 button=1
03-05 09:48:10.550+0900 W/WATCH_CORE(  838): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
03-05 09:48:10.550+0900 I/WATCH_CORE(  838): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
03-05 09:48:10.550+0900 I/CAPI_WATCH_APPLICATION(  838): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-05 09:48:10.550+0900 E/watchface-loader(  838): watchface-loader.cpp: OnAppTimeTick(673) > 
03-05 09:48:10.550+0900 I/watchface-loader(  838): watchface-loader.cpp: OnAppTimeTick(684) > set force update!!
03-05 09:48:10.555+0900 E/wnoti-service(  898): wnoti-db-utility.c: context_wearonoff_status_cb(1781) > status changed from 2 to 2 
03-05 09:48:10.555+0900 W/LibServiceCommon( 1137): ContextCommonProxy.cpp: OnContextWearEventCB(570) > [1;40;33mstatus changed [2][0;m
03-05 09:48:10.555+0900 W/LibServiceCommon( 1137): ContinuousHrFeatureController.cpp: OnWearOff(257) > [1;40;33m#[0;m
03-05 09:48:10.555+0900 E/WMS     (  534): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23195) > wear_monitor_status update[0] = 2 -> 2
03-05 09:48:10.555+0900 W/WECONN  (  518): <__wc_feature_wearonoff_monitor_cb:532> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
03-05 09:48:10.555+0900 W/WECONN  (  518): <__wc_device_on_wear_onoff_changed_cb:361> { state=WC_FEATURE_STATE_OFF
03-05 09:48:10.555+0900 W/WECONN  (  518): <__wc_device_on_wear_onoff_changed_cb:391> }
03-05 09:48:10.555+0900 W/WECONN  (  518): <__wc_feature_wearonoff_monitor_cb:552> }
03-05 09:48:11.485+0900 W/WATCH_CORE(  838): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
03-05 09:48:11.485+0900 I/WATCH_CORE(  838): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
03-05 09:48:11.490+0900 I/CAPI_WATCH_APPLICATION(  838): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-05 09:48:11.490+0900 E/watchface-loader(  838): watchface-loader.cpp: OnAppTimeTick(673) > 
03-05 09:48:11.490+0900 I/watchface-loader(  838): watchface-loader.cpp: OnAppTimeTick(684) > set force update!!
03-05 09:48:11.520+0900 W/WATCH_CORE(  838): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
03-05 09:48:11.525+0900 W/STARTER (  722): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
03-05 09:48:11.525+0900 W/STARTER (  722): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
03-05 09:48:11.525+0900 E/STARTER (  722): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
03-05 09:48:11.525+0900 W/STARTER (  722): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
03-05 09:48:11.525+0900 W/STARTER (  722): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
03-05 09:48:11.755+0900 W/SHealthCommon( 1137): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
03-05 09:48:11.755+0900 W/LibServiceCommon( 1137): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(645) > [1;35m ###[0;m
03-05 09:48:11.755+0900 W/LibServiceCommon( 1137): ContinuousHrFeatureController.cpp: Stop(142) > [1;40;33mwas not running[0;m
03-05 09:48:11.760+0900 W/SHealthCommon(  868): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
03-05 09:48:11.770+0900 I/watchface-viewer(  838): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
03-05 09:48:11.790+0900 W/STARTER (  722): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
03-05 09:48:11.810+0900 W/STARTER (  722): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
03-05 09:48:11.810+0900 W/STARTER (  722): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
03-05 09:48:11.810+0900 W/STARTER (  722): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
03-05 09:48:11.810+0900 E/ALARM_MANAGER(  722): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(5-3-2020, 09:48:32), repeat(1), interval(20), type(-1073741822)
03-05 09:48:11.815+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [722].
03-05 09:48:11.855+0900 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 610918865, next duetime: 1583369312
03-05 09:48:11.855+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_add_to_list(485) > [alarm-server]: After add alarm_id(610918865)
03-05 09:48:11.855+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_create(1050) > [alarm-server]:alarm_context.c_due_time(1583372289), due_time(1583369312)
03-05 09:48:11.860+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
03-05 09:48:11.860+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 5-3-2020, 00:48:32 (UTC).
03-05 09:48:11.860+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
03-05 09:48:12.285+0900 W/WATCH_CORE(  838): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
03-05 09:48:12.285+0900 I/WATCH_CORE(  838): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
03-05 09:48:12.285+0900 I/CAPI_WATCH_APPLICATION(  838): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-05 09:48:12.285+0900 E/watchface-loader(  838): watchface-loader.cpp: OnAppTimeTick(673) > 
03-05 09:48:12.285+0900 I/watchface-loader(  838): watchface-loader.cpp: OnAppTimeTick(684) > set force update!!
03-05 09:48:12.335+0900 W/WATCH_CORE(  838): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
03-05 09:48:12.335+0900 I/WATCH_CORE(  838): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
03-05 09:48:12.335+0900 I/CAPI_WATCH_APPLICATION(  838): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-05 09:48:12.335+0900 E/watchface-loader(  838): watchface-loader.cpp: OnAppTimeTick(673) > 
03-05 09:48:12.335+0900 I/watchface-loader(  838): watchface-loader.cpp: OnAppTimeTick(684) > set force update!!
03-05 09:48:12.340+0900 W/STARTER (  722): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [808]ms
03-05 09:48:12.340+0900 W/STARTER (  722): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
03-05 09:48:12.385+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [722].
03-05 09:48:12.385+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_remove_from_list(564) > [alarm-server]:Remove alarm id(610918865)
03-05 09:48:12.385+0900 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(696910647) is OVER.
03-05 09:48:12.385+0900 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2097796370) is OVER.
03-05 09:48:12.385+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
03-05 09:48:12.385+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 5-3-2020, 01:38:09 (UTC).
03-05 09:48:12.385+0900 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
03-05 09:48:12.385+0900 E/ALARM_MANAGER(  519): alarm-manager.c: alarm_manager_alarm_delete(2457) > alarm_id[610918865] is removed.
03-05 09:48:12.390+0900 W/W_INDICATOR(  732): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(374) > [_windicator_dbus_lcd_changed_cb:374] 374, str=[gesture],charge : 0, connected : 0
03-05 09:48:12.545+0900 W/SHealthCommon( 1137): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
03-05 09:48:12.545+0900 W/LibServiceCommon( 1137): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(645) > [1;35m ###[0;m
03-05 09:48:12.545+0900 I/watchface-viewer(  838): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
03-05 09:48:12.550+0900 W/SHealthCommon(  868): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
03-05 09:48:12.555+0900 W/LibServiceCommon( 1137): GearEnergyExpenditure.cpp: GetCaloriesDiffFromBaseEnergyExpenditure(86) > [1;40;33mdiff = [10.059493][0;m
03-05 09:48:12.555+0900 W/LibServiceCommon( 1137): EnergyExpenditureFeatureController.cpp: CalcurateTEECalorie(136) > [1;40;33m667.017743 total = 656.958250 from host, 10.059493 from base diff[0;m
03-05 09:48:12.555+0900 W/LibServiceCommon( 1137): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1583334000000.000000, end 1583369292557.000000, calories 667.017743[0;m
03-05 09:48:12.555+0900 W/SHealthCommon( 1137): SHealthMessagePortConnection.cpp: SendServiceMessage(557) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
03-05 09:48:12.575+0900 W/STARTER (  722): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
03-05 09:48:12.575+0900 W/STARTER (  722): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
03-05 09:48:14.060+0900 E/AUL_AMD (  547): amd_launch.c: __recv_timeout_handler(944) > application is not responding : pid(3956) cmd(0)
03-05 09:48:14.060+0900 W/AUL_AMD (  547): amd_launch.c: __send_watchdog_signal(426) > send a watchdog signal done: 3956
03-05 09:48:14.065+0900 E/RESOURCED(  549): proc-monitor.c: proc_dbus_watchdog_handler(784) > Receive watchdog signal to pid: 3956(sensorapp)
03-05 09:48:14.065+0900 E/RESOURCED(  549): proc-monitor.c: proc_dbus_watchdog_handler(795) > just kill watchdog process when debug enabled pid: 3956(sensorapp)
03-05 09:48:14.205+0900 W/CRASH_MANAGER( 1335): worker.c: worker_job(1205) > 060395673656e158336929
