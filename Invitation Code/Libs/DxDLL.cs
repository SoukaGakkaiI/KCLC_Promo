using System.Runtime.InteropServices;
namespace DxLibDLL
{
	public static class DX
	{
		public const int TRUE  = 1;
		public const int FALSE = 0;
		public const int MAX_IMAGE_NUM = 32768;
		public const int MAX_2DSURFACE_NUM = 32768;
		public const int MAX_3DSURFACE_NUM = 65536;
		public const int MAX_IMAGE_DIVNUM = 64;
		public const int MAX_SURFACE_NUM = 65536;
		public const int MAX_SOFTIMAGE_NUM = 8192;
		public const int MAX_SOUND_NUM = 32768;
		public const int MAX_SOFTSOUND_NUM = 8192;
		public const int MAX_MUSIC_NUM = 256;
		public const int MAX_MOVIE_NUM = 100;
		public const int MAX_MASK_NUM = 512;
		public const int MAX_FONT_NUM = 40;
		public const int MAX_INPUT_NUM = 256;
		public const int MAX_SOCKET_NUM = 8192;
		public const int MAX_LIGHT_NUM = 4096;
		public const int MAX_SHADER_NUM = 4096;
		public const int MAX_VERTEX_BUFFER_NUM = 16384;
		public const int MAX_INDEX_BUFFER_NUM = 16384;
		public const int MAX_JOYPAD_NUM = 16;
		public const int MAX_EVENTPROCESS_NUM = 5;
		public const int DEFAULT_SCREEN_SIZE_X = 640;
		public const int DEFAULT_SCREEN_SIZE_Y = 480;
		public const int DEFAULT_COLOR_BITDEPTH = 16;
		public const int FONT_CACHE_MAXNUM = 2024;
		public const int FONT_CACHE_MEMORYSIZE = 327680;
		public const int FONT_CACHE_MAX_YLENGTH = 16384;
		public const int MAX_USERIMAGEREAD_FUNCNUM = 10;
		public const int DX_HANDLEINDEX_MASK = 65535;
		public const int DX_HANDLECHECKBIT_MASK = 134152192;
		public const int DX_HANDLECHECKBIT_ADDRESS = 16;
		public const int DX_HANDLETYPE_MASK = 2013265920;
		public const int DX_HANDLEERROR_MASK = -2147483648;
		public const int DX_HANDLEERROR_OR_TYPE_MASK = -134217728;
		public const int DX_HANDLETYPE_GRAPH = 134217728;
		public const int DX_HANDLETYPE_SOUND = 268435456;
		public const int DX_HANDLETYPE_MOVIE = 402653184;
		public const int DX_HANDLETYPE_FONT = 536870912;
		public const int DX_HANDLETYPE_GMASK = 671088640;
		public const int DX_HANDLETYPE_NETWORK = 805306368;
		public const int DX_HANDLETYPE_KEYINPUT = 939524096;
		public const int DX_HANDLETYPE_MUSIC = 1073741824;
		public const int DX_HANDLETYPE_LIGHT = 1207959552;
		public const int DX_HANDLETYPE_MODEL = 1342177280;
		public const int DX_HANDLETYPE_SOFTIMAGE = 1476395008;
		public const int DX_HANDLETYPE_SHADER = 1610612736;
		public const int DX_HANDLETYPE_SOFTSOUND = 1744830464;
		public const int DX_HANDLETYPE_VERTEX_BUFFER = 1879048192;
		public const int DX_HANDLETYPE_INDEX_BUFFER = 2013265920;
		public const int DX_WINDOWSVERSION_31 = 0;
		public const int DX_WINDOWSVERSION_95 = 1;
		public const int DX_WINDOWSVERSION_98 = 2;
		public const int DX_WINDOWSVERSION_ME = 3;
		public const int DX_WINDOWSVERSION_NT31 = 260;
		public const int DX_WINDOWSVERSION_NT40 = 261;
		public const int DX_WINDOWSVERSION_2000 = 262;
		public const int DX_WINDOWSVERSION_XP = 263;
		public const int DX_WINDOWSVERSION_VISTA = 264;
		public const int DX_WINDOWSVERSION_7 = 265;
		public const int DX_WINDOWSVERSION_NT_TYPE = 256;
		public const int DX_DIRECTXVERSION_NON = 0;
		public const int DX_DIRECTXVERSION_1 = 65536;
		public const int DX_DIRECTXVERSION_2 = 131072;
		public const int DX_DIRECTXVERSION_3 = 196608;
		public const int DX_DIRECTXVERSION_4 = 262144;
		public const int DX_DIRECTXVERSION_5 = 327680;
		public const int DX_DIRECTXVERSION_6 = 393216;
		public const int DX_DIRECTXVERSION_6_1 = 393472;
		public const int DX_DIRECTXVERSION_7 = 458752;
		public const int DX_DIRECTXVERSION_8 = 524288;
		public const int DX_DIRECTXVERSION_8_1 = 524544;
		public const int DX_CHARSET_DEFAULT = 0;
		public const int DX_CHARSET_SHFTJIS = 1;
		public const int DX_CHARSET_HANGEUL = 2;
		public const int DX_CHARSET_BIG5 = 3;
		public const int DX_CHARSET_GB2312 = 4;
		public const int DX_MIDIMODE_MCI = 0;
		public const int DX_MIDIMODE_DM = 1;
		public const int DX_DRAWMODE_NEAREST = 0;
		public const int DX_DRAWMODE_BILINEAR = 1;
		public const int DX_DRAWMODE_ANISOTROPIC = 2;
		public const int DX_DRAWMODE_OTHER = 3;
		public const int DX_FONTTYPE_NORMAL = 0;
		public const int DX_FONTTYPE_EDGE = 1;
		public const int DX_FONTTYPE_ANTIALIASING = 2;
		public const int DX_FONTTYPE_ANTIALIASING_EDGE = 3;
		public const int DX_BLENDMODE_NOBLEND = 0;
		public const int DX_BLENDMODE_ALPHA = 1;
		public const int DX_BLENDMODE_ADD = 2;
		public const int DX_BLENDMODE_SUB = 3;
		public const int DX_BLENDMODE_MUL = 4;
		public const int DX_BLENDMODE_SUB2 = 5;
		public const int DX_BLENDMODE_XOR = 6;
		public const int DX_BLENDMODE_DESTCOLOR = 8;
		public const int DX_BLENDMODE_INVDESTCOLOR = 9;
		public const int DX_BLENDMODE_INVSRC = 10;
		public const int DX_BLENDMODE_MULA = 11;
		public const int DX_BLENDMODE_ALPHA_X4 = 12;
		public const int DX_BLENDMODE_ADD_X4 = 13;
		public const int DX_BLENDMODE_SRCCOLOR = 14;
		public const int DX_GRAPH_FILTER_MONO = 0;
		public const int DX_GRAPH_FILTER_GAUSS = 1;
		public const int DX_GRAPH_FILTER_DOWN_SCALE = 2;
		public const int DX_GRAPH_FILTER_BRIGHT_CLIP = 3;
		public const int DX_GRAPH_FILTER_HSB = 4;
		public const int DX_GRAPH_FILTER_INVERT = 5;
		public const int DX_GRAPH_FILTER_LEVEL = 6;
		public const int DX_GRAPH_FILTER_TWO_COLOR = 7;
		public const int DX_GRAPH_FILTER_GRADIENT_MAP = 8;
		public const int DX_GRAPH_FILTER_NUM = 9;
		public const int DX_GRAPH_BLEND_NORMAL = 0;
		public const int DX_GRAPH_BLEND_RGBA_SELECT_MIX = 1;
		public const int DX_GRAPH_BLEND_MULTIPLE = 2;
		public const int DX_GRAPH_BLEND_DIFFERENCE = 3;
		public const int DX_GRAPH_BLEND_ADD = 4;
		public const int DX_GRAPH_BLEND_SCREEN = 5;
		public const int DX_GRAPH_BLEND_OVERLAY = 6;
		public const int DX_GRAPH_BLEND_DODGE = 7;
		public const int DX_GRAPH_BLEND_BURN = 8;
		public const int DX_GRAPH_BLEND_DARKEN = 9;
		public const int DX_GRAPH_BLEND_LIGHTEN = 10;
		public const int DX_GRAPH_BLEND_SOFTLIGHT = 11;
		public const int DX_GRAPH_BLEND_HARDLIGHT = 12;
		public const int DX_GRAPH_BLEND_EXCLUSION = 13;
		public const int DX_GRAPH_BLEND_NUM = 14;
		public const int DX_RGBA_SELECT_SRC_R = 0;
		public const int DX_RGBA_SELECT_SRC_G = 1;
		public const int DX_RGBA_SELECT_SRC_B = 2;
		public const int DX_RGBA_SELECT_SRC_A = 3;
		public const int DX_RGBA_SELECT_BLEND_R = 4;
		public const int DX_RGBA_SELECT_BLEND_G = 5;
		public const int DX_RGBA_SELECT_BLEND_B = 6;
		public const int DX_RGBA_SELECT_BLEND_A = 7;
		public const int DX_CULLING_NONE = 0;
		public const int DX_CULLING_LEFT = 1;
		public const int DX_CULLING_RIGHT = 2;
		public const int DX_SCREEN_FRONT = -4;
		public const int DX_SCREEN_BACK = -2;
		public const int DX_SCREEN_WORK = -3;
		public const int DX_SCREEN_TEMPFRONT = -5;
		public const int DX_NONE_GRAPH = -5;
		public const int DX_SHAVEDMODE_NONE = 0;
		public const int DX_SHAVEDMODE_DITHER = 1;
		public const int DX_SHAVEDMODE_DIFFUS = 2;
		public const int DX_IMAGESAVETYPE_BMP = 0;
		public const int DX_IMAGESAVETYPE_JPEG = 1;
		public const int DX_IMAGESAVETYPE_PNG = 2;
		public const int DX_PLAYTYPE_LOOPBIT = 2;
		public const int DX_PLAYTYPE_BACKBIT = 1;
		public const int DX_PLAYTYPE_NORMAL = 0;
		public const int DX_PLAYTYPE_BACK = ( DX_PLAYTYPE_BACKBIT  );
		public const int DX_PLAYTYPE_LOOP = ( DX_PLAYTYPE_LOOPBIT | DX_PLAYTYPE_BACKBIT  );
		public const int DX_MOVIEPLAYTYPE_BCANCEL = 0;
		public const int DX_MOVIEPLAYTYPE_NORMAL = 1;
		public const int DX_SOUNDTYPE_NORMAL = 0;
		public const int DX_SOUNDTYPE_STREAMSTYLE = 1;
		public const int DX_SOUNDDATATYPE_MEMNOPRESS = 0;
		public const int DX_SOUNDDATATYPE_MEMNOPRESS_PLUS = 1;
		public const int DX_SOUNDDATATYPE_MEMPRESS = 2;
		public const int DX_SOUNDDATATYPE_FILE = 3;
		public const int DX_READSOUNDFUNCTION_PCM = 1;
		public const int DX_READSOUNDFUNCTION_ACM = 2;
		public const int DX_READSOUNDFUNCTION_OGG = 4;
		public const int DX_READSOUNDFUNCTION_MP3 = 8;
		public const int DX_READSOUNDFUNCTION_DSMP3 = 16;
		public const int DX_MASKTRANS_WHITE = 0;
		public const int DX_MASKTRANS_BLACK = 1;
		public const int DX_MASKTRANS_NONE = 2;
		public const int DX_ZWRITE_MASK = 0;
		public const int DX_ZWRITE_CLEAR = 1;
		public const int DX_CMP_NEVER = 1;
		public const int DX_CMP_LESS = 2;
		public const int DX_CMP_EQUAL = 3;
		public const int DX_CMP_LESSEQUAL = 4;
		public const int DX_CMP_GREATER = 5;
		public const int DX_CMP_NOTEQUAL = 6;
		public const int DX_CMP_GREATEREQUAL = 7;
		public const int DX_CMP_ALWAYS = 8;
		public const int DX_ZCMP_DEFAULT = ( DX_CMP_LESSEQUAL  );
		public const int DX_ZCMP_REVERSE = ( DX_CMP_GREATEREQUAL  );
		public const int DX_SHADEMODE_FLAT = 1;
		public const int DX_SHADEMODE_GOURAUD = 2;
		public const int DX_FOGMODE_NONE = 0;
		public const int DX_FOGMODE_EXP = 1;
		public const int DX_FOGMODE_EXP2 = 2;
		public const int DX_FOGMODE_LINEAR = 3;
		public const int DX_MATERIAL_TYPE_NORMAL = 0;
		public const int DX_MATERIAL_TYPE_TOON = 1;
		public const int DX_MATERIAL_TYPE_TOON_2 = 2;
		public const int DX_MATERIAL_BLENDTYPE_TRANSLUCENT = 0;
		public const int DX_MATERIAL_BLENDTYPE_ADDITIVE = 1;
		public const int DX_MATERIAL_BLENDTYPE_MODULATE = 2;
		public const int DX_TEXADDRESS_WRAP = 1;
		public const int DX_TEXADDRESS_MIRROR = 2;
		public const int DX_TEXADDRESS_CLAMP = 3;
		public const int DX_TEXADDRESS_BORDER = 4;
		public const int DX_VERTEX_TYPE_NORMAL_3D = 0;
		public const int DX_INDEX_TYPE_16BIT = 0;
		public const int DX_LOADMODEL_PHYSICS_DISABLE = 1;
		public const int DX_LOADMODEL_PHYSICS_LOADCALC = 0;
		public const int DX_LOADMODEL_PHYSICS_REALTIME = 2;
		public const int DX_PRIMTYPE_POINTLIST = 1;
		public const int DX_PRIMTYPE_LINELIST = 2;
		public const int DX_PRIMTYPE_LINESTRIP = 3;
		public const int DX_PRIMTYPE_TRIANGLELIST = 4;
		public const int DX_PRIMTYPE_TRIANGLESTRIP = 5;
		public const int DX_PRIMTYPE_TRIANGLEFAN = 6;
		public const int DX_LIGHTTYPE_D3DLIGHT_POINT = 1;
		public const int DX_LIGHTTYPE_D3DLIGHT_SPOT = 2;
		public const int DX_LIGHTTYPE_D3DLIGHT_DIRECTIONAL = 3;
		public const int DX_LIGHTTYPE_D3DLIGHT_FORCEDWORD = 2147483647;
		public const int DX_LIGHTTYPE_POINT = 1;
		public const int DX_LIGHTTYPE_SPOT = 2;
		public const int DX_LIGHTTYPE_DIRECTIONAL = 3;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_RGB16 = 0;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_RGB32 = 1;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHA_RGB16 = 2;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHA_RGB32 = 3;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHATEST_RGB16 = 4;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHATEST_RGB32 = 5;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT1 = 6;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT2 = 7;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT3 = 8;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT4 = 9;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT5 = 10;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_RGB16 = 11;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_RGB32 = 12;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ALPHA_RGB32 = 13;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ABGR_F16 = 14;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ABGR_F32 = 15;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_NUM = 16;
		public const int DX_GRAPHICSIMAGE_FORMAT_2D = 17;
		public const int DX_GRAPHICSIMAGE_FORMAT_R5G6B5 = 18;
		public const int DX_GRAPHICSIMAGE_FORMAT_X8A8R5G6B5 = 19;
		public const int DX_GRAPHICSIMAGE_FORMAT_X8R8G8B8 = 20;
		public const int DX_GRAPHICSIMAGE_FORMAT_A8R8G8B8 = 21;
		public const int DX_GRAPHICSIMAGE_FORMAT_NUM = 22;
		public const int DX_BASEIMAGE_FORMAT_NORMAL = 0;
		public const int DX_BASEIMAGE_FORMAT_DXT1 = 1;
		public const int DX_BASEIMAGE_FORMAT_DXT2 = 2;
		public const int DX_BASEIMAGE_FORMAT_DXT3 = 3;
		public const int DX_BASEIMAGE_FORMAT_DXT4 = 4;
		public const int DX_BASEIMAGE_FORMAT_DXT5 = 5;
		public const int DX_BASEIMAGE_FORMAT_ABGR_F16 = 6;
		public const int DX_BASEIMAGE_FORMAT_ABGR_F32 = 7;
		public const int TOOLBUTTON_STATE_ENABLE = 0;
		public const int TOOLBUTTON_STATE_PRESSED = 1;
		public const int TOOLBUTTON_STATE_DISABLE = 2;
		public const int TOOLBUTTON_STATE_PRESSED_DISABLE = 3;
		public const int TOOLBUTTON_STATE_NUM = 4;
		public const int TOOLBUTTON_TYPE_NORMAL = 0;
		public const int TOOLBUTTON_TYPE_CHECK = 1;
		public const int TOOLBUTTON_TYPE_GROUP = 2;
		public const int TOOLBUTTON_TYPE_SEP = 3;
		public const int TOOLBUTTON_TYPE_NUM = 4;
		public const int MENUITEM_IDTOP = -1414812757;
		public const int MENUITEM_ADD_CHILD = 0;
		public const int MENUITEM_ADD_INSERT = 1;
		public const int MENUITEM_MARK_NONE = 0;
		public const int MENUITEM_MARK_CHECK = 1;
		public const int MENUITEM_MARK_RADIO = 2;
		public const int DX_NUMMODE_10 = 0;
		public const int DX_NUMMODE_16 = 1;
		public const int DX_STRMODE_NOT0 = 2;
		public const int DX_STRMODE_USE0 = 3;
		public const int DX_CHECKINPUT_KEY = 1;
		public const int DX_CHECKINPUT_PAD = 2;
		public const int DX_CHECKINPUT_MOUSE = 4;
		public const int DX_CHECKINPUT_ALL = DX_CHECKINPUT_KEY;
		public const int DX_INPUT_KEY_PAD1 = 4097;
		public const int DX_INPUT_PAD1 = 1;
		public const int DX_INPUT_PAD2 = 2;
		public const int DX_INPUT_PAD3 = 3;
		public const int DX_INPUT_PAD4 = 4;
		public const int DX_INPUT_PAD5 = 5;
		public const int DX_INPUT_PAD6 = 6;
		public const int DX_INPUT_PAD7 = 7;
		public const int DX_INPUT_PAD8 = 8;
		public const int DX_INPUT_PAD9 = 9;
		public const int DX_INPUT_PAD10 = 10;
		public const int DX_INPUT_PAD11 = 11;
		public const int DX_INPUT_PAD12 = 12;
		public const int DX_INPUT_PAD13 = 13;
		public const int DX_INPUT_PAD14 = 14;
		public const int DX_INPUT_PAD15 = 15;
		public const int DX_INPUT_PAD16 = 16;
		public const int DX_INPUT_KEY = 4096;
		public const int DX_MOVIESURFACE_NORMAL = 0;
		public const int DX_MOVIESURFACE_OVERLAY = 1;
		public const int DX_MOVIESURFACE_FULLCOLOR = 2;
		public const int PAD_INPUT_DOWN = 1;
		public const int PAD_INPUT_LEFT = 2;
		public const int PAD_INPUT_RIGHT = 4;
		public const int PAD_INPUT_UP = 8;
		public const int PAD_INPUT_A = 16;
		public const int PAD_INPUT_B = 32;
		public const int PAD_INPUT_C = 64;
		public const int PAD_INPUT_X = 128;
		public const int PAD_INPUT_Y = 256;
		public const int PAD_INPUT_Z = 512;
		public const int PAD_INPUT_L = 1024;
		public const int PAD_INPUT_R = 2048;
		public const int PAD_INPUT_START = 4096;
		public const int PAD_INPUT_M = 8192;
		public const int PAD_INPUT_D = 16384;
		public const int PAD_INPUT_F = 32768;
		public const int PAD_INPUT_G = 65536;
		public const int PAD_INPUT_H = 131072;
		public const int PAD_INPUT_I = 262144;
		public const int PAD_INPUT_J = 524288;
		public const int PAD_INPUT_K = 1048576;
		public const int PAD_INPUT_LL = 2097152;
		public const int PAD_INPUT_N = 4194304;
		public const int PAD_INPUT_O = 8388608;
		public const int PAD_INPUT_P = 16777216;
		public const int PAD_INPUT_RR = 33554432;
		public const int PAD_INPUT_S = 67108864;
		public const int PAD_INPUT_T = 134217728;
		public const int PAD_INPUT_U = 268435456;
		public const int PAD_INPUT_V = 536870912;
		public const int PAD_INPUT_W = 1073741824;
		public const int PAD_INPUT_XX = -2147483648;
		public const int PAD_INPUT_1 = 16;
		public const int PAD_INPUT_2 = 32;
		public const int PAD_INPUT_3 = 64;
		public const int PAD_INPUT_4 = 128;
		public const int PAD_INPUT_5 = 256;
		public const int PAD_INPUT_6 = 512;
		public const int PAD_INPUT_7 = 1024;
		public const int PAD_INPUT_8 = 2048;
		public const int PAD_INPUT_9 = 4096;
		public const int PAD_INPUT_10 = 8192;
		public const int PAD_INPUT_11 = 16384;
		public const int PAD_INPUT_12 = 32768;
		public const int PAD_INPUT_13 = 65536;
		public const int PAD_INPUT_14 = 131072;
		public const int PAD_INPUT_15 = 262144;
		public const int PAD_INPUT_16 = 524288;
		public const int PAD_INPUT_17 = 1048576;
		public const int PAD_INPUT_18 = 2097152;
		public const int PAD_INPUT_19 = 4194304;
		public const int PAD_INPUT_20 = 8388608;
		public const int PAD_INPUT_21 = 16777216;
		public const int PAD_INPUT_22 = 33554432;
		public const int PAD_INPUT_23 = 67108864;
		public const int PAD_INPUT_24 = 134217728;
		public const int PAD_INPUT_25 = 268435456;
		public const int PAD_INPUT_26 = 536870912;
		public const int PAD_INPUT_27 = 1073741824;
		public const int PAD_INPUT_28 = -2147483648;
		public const int MOUSE_INPUT_LEFT = 1;
		public const int MOUSE_INPUT_RIGHT = 2;
		public const int MOUSE_INPUT_MIDDLE = 4;
		public const int MOUSE_INPUT_1 = 1;
		public const int MOUSE_INPUT_2 = 2;
		public const int MOUSE_INPUT_3 = 4;
		public const int MOUSE_INPUT_4 = 8;
		public const int MOUSE_INPUT_5 = 16;
		public const int MOUSE_INPUT_6 = 32;
		public const int MOUSE_INPUT_7 = 64;
		public const int MOUSE_INPUT_8 = 128;
		public const int KEY_INPUT_BACK = 14;
		public const int KEY_INPUT_TAB = 15;
		public const int KEY_INPUT_RETURN = 28;
		public const int KEY_INPUT_LSHIFT = 42;
		public const int KEY_INPUT_RSHIFT = 54;
		public const int KEY_INPUT_LCONTROL = 29;
		public const int KEY_INPUT_RCONTROL = 157;
		public const int KEY_INPUT_ESCAPE = 1;
		public const int KEY_INPUT_SPACE = 57;
		public const int KEY_INPUT_PGUP = 201;
		public const int KEY_INPUT_PGDN = 209;
		public const int KEY_INPUT_END = 207;
		public const int KEY_INPUT_HOME = 199;
		public const int KEY_INPUT_LEFT = 203;
		public const int KEY_INPUT_UP = 200;
		public const int KEY_INPUT_RIGHT = 205;
		public const int KEY_INPUT_DOWN = 208;
		public const int KEY_INPUT_INSERT = 210;
		public const int KEY_INPUT_DELETE = 211;
		public const int KEY_INPUT_MINUS = 12;
		public const int KEY_INPUT_YEN = 125;
		public const int KEY_INPUT_PREVTRACK = 144;
		public const int KEY_INPUT_PERIOD = 52;
		public const int KEY_INPUT_SLASH = 53;
		public const int KEY_INPUT_LALT = 56;
		public const int KEY_INPUT_RALT = 184;
		public const int KEY_INPUT_SCROLL = 70;
		public const int KEY_INPUT_SEMICOLON = 39;
		public const int KEY_INPUT_COLON = 146;
		public const int KEY_INPUT_LBRACKET = 26;
		public const int KEY_INPUT_RBRACKET = 27;
		public const int KEY_INPUT_AT = 145;
		public const int KEY_INPUT_BACKSLASH = 43;
		public const int KEY_INPUT_COMMA = 51;
		public const int KEY_INPUT_KANJI = 148;
		public const int KEY_INPUT_CONVERT = 121;
		public const int KEY_INPUT_NOCONVERT = 123;
		public const int KEY_INPUT_KANA = 112;
		public const int KEY_INPUT_APPS = 221;
		public const int KEY_INPUT_CAPSLOCK = 58;
		public const int KEY_INPUT_SYSRQ = 183;
		public const int KEY_INPUT_PAUSE = 197;
		public const int KEY_INPUT_LWIN = 219;
		public const int KEY_INPUT_RWIN = 220;
		public const int KEY_INPUT_NUMLOCK = 69;
		public const int KEY_INPUT_NUMPAD0 = 82;
		public const int KEY_INPUT_NUMPAD1 = 79;
		public const int KEY_INPUT_NUMPAD2 = 80;
		public const int KEY_INPUT_NUMPAD3 = 81;
		public const int KEY_INPUT_NUMPAD4 = 75;
		public const int KEY_INPUT_NUMPAD5 = 76;
		public const int KEY_INPUT_NUMPAD6 = 77;
		public const int KEY_INPUT_NUMPAD7 = 71;
		public const int KEY_INPUT_NUMPAD8 = 72;
		public const int KEY_INPUT_NUMPAD9 = 73;
		public const int KEY_INPUT_MULTIPLY = 55;
		public const int KEY_INPUT_ADD = 78;
		public const int KEY_INPUT_SUBTRACT = 74;
		public const int KEY_INPUT_DECIMAL = 83;
		public const int KEY_INPUT_DIVIDE = 181;
		public const int KEY_INPUT_NUMPADENTER = 156;
		public const int KEY_INPUT_F1 = 59;
		public const int KEY_INPUT_F2 = 60;
		public const int KEY_INPUT_F3 = 61;
		public const int KEY_INPUT_F4 = 62;
		public const int KEY_INPUT_F5 = 63;
		public const int KEY_INPUT_F6 = 64;
		public const int KEY_INPUT_F7 = 65;
		public const int KEY_INPUT_F8 = 66;
		public const int KEY_INPUT_F9 = 67;
		public const int KEY_INPUT_F10 = 68;
		public const int KEY_INPUT_F11 = 87;
		public const int KEY_INPUT_F12 = 88;
		public const int KEY_INPUT_A = 30;
		public const int KEY_INPUT_B = 48;
		public const int KEY_INPUT_C = 46;
		public const int KEY_INPUT_D = 32;
		public const int KEY_INPUT_E = 18;
		public const int KEY_INPUT_F = 33;
		public const int KEY_INPUT_G = 34;
		public const int KEY_INPUT_H = 35;
		public const int KEY_INPUT_I = 23;
		public const int KEY_INPUT_J = 36;
		public const int KEY_INPUT_K = 37;
		public const int KEY_INPUT_L = 38;
		public const int KEY_INPUT_M = 50;
		public const int KEY_INPUT_N = 49;
		public const int KEY_INPUT_O = 24;
		public const int KEY_INPUT_P = 25;
		public const int KEY_INPUT_Q = 16;
		public const int KEY_INPUT_R = 19;
		public const int KEY_INPUT_S = 31;
		public const int KEY_INPUT_T = 20;
		public const int KEY_INPUT_U = 22;
		public const int KEY_INPUT_V = 47;
		public const int KEY_INPUT_W = 17;
		public const int KEY_INPUT_X = 45;
		public const int KEY_INPUT_Y = 21;
		public const int KEY_INPUT_Z = 44;
		public const int KEY_INPUT_0 = 11;
		public const int KEY_INPUT_1 = 2;
		public const int KEY_INPUT_2 = 3;
		public const int KEY_INPUT_3 = 4;
		public const int KEY_INPUT_4 = 5;
		public const int KEY_INPUT_5 = 6;
		public const int KEY_INPUT_6 = 7;
		public const int KEY_INPUT_7 = 8;
		public const int KEY_INPUT_8 = 9;
		public const int KEY_INPUT_9 = 10;
		public const int CTRL_CODE_BS = 8;
		public const int CTRL_CODE_TAB = 9;
		public const int CTRL_CODE_CR = 13;
		public const int CTRL_CODE_DEL = 16;
		public const int CTRL_CODE_COPY = 3;
		public const int CTRL_CODE_PASTE = 22;
		public const int CTRL_CODE_CUT = 24;
		public const int CTRL_CODE_ALL = 1;
		public const int CTRL_CODE_LEFT = 29;
		public const int CTRL_CODE_RIGHT = 28;
		public const int CTRL_CODE_UP = 30;
		public const int CTRL_CODE_DOWN = 31;
		public const int CTRL_CODE_HOME = 26;
		public const int CTRL_CODE_END = 25;
		public const int CTRL_CODE_PAGE_UP = 23;
		public const int CTRL_CODE_PAGE_DOWN = 21;
		public const int CTRL_CODE_ESC = 27;
		public const int CTRL_CODE_CMP = 32;
		public const int DX_CHANGESCREEN_OK = 0;
		public const int DX_CHANGESCREEN_RETURN = 1;
		public const int DX_CHANGESCREEN_DEFAULT = 2;
		public const int DX_CHANGESCREEN_REFRESHNORMAL = 3;
		public const int LOADIMAGE_TYPE_FILE = 0;
		public const int LOADIMAGE_TYPE_MEM = 1;
		public const int LOADIMAGE_TYPE_NONE = 1;
		public const int DRAWPREP_TRANS = 1;
		public const int DRAWPREP_VECTORINT = 2;
		public const int DRAWPREP_GOURAUDSHADE = 8;
		public const int DRAWPREP_PERSPECTIVE = 16;
		public const int DRAWPREP_DIFFUSERGB = 32;
		public const int DRAWPREP_DIFFUSEALPHA = 64;
		public const int DRAWPREP_FOG = 128;
		public const int DRAWPREP_NOBLENDSETTING = 256;
		public const int DRAWPREP_LIGHTING = 512;
		public const int DRAWPREP_SPECULAR = 1024;
		public const int DRAWPREP_3D = 2048;
		public const int DRAWPREP_TEXADDRESS = 4096;
		public const int DRAWPREP_NOTSHADERRESET = 8192;
		public const int HTTP_ERR_SERVER = 0;
		public const int HTTP_ERR_NOTFOUND = 1;
		public const int HTTP_ERR_MEMORY = 2;
		public const int HTTP_ERR_LOST = 3;
		public const int HTTP_ERR_NONE = 1;
		public const int HTTP_RES_COMPLETE = 0;
		public const int HTTP_RES_STOP = 1;
		public const int HTTP_RES_ERROR = 2;
		public const int HTTP_RES_NOW = 1;

		[StructLayout(LayoutKind.Explicit)]
		public struct IPDATA_IPv6
		{
			[FieldOffset(0)] public byte Byte00;
			[FieldOffset(1)] public byte Byte01;
			[FieldOffset(2)] public byte Byte02;
			[FieldOffset(3)] public byte Byte03;
			[FieldOffset(4)] public byte Byte04;
			[FieldOffset(5)] public byte Byte05;
			[FieldOffset(6)] public byte Byte06;
			[FieldOffset(7)] public byte Byte07;
			[FieldOffset(8)] public byte Byte08;
			[FieldOffset(9)] public byte Byte09;
			[FieldOffset(10)] public byte Byte10;
			[FieldOffset(11)] public byte Byte11;
			[FieldOffset(12)] public byte Byte12;
			[FieldOffset(13)] public byte Byte13;
			[FieldOffset(14)] public byte Byte14;
			[FieldOffset(15)] public byte Byte15;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IPDATA
		{
			[FieldOffset(0)] public byte d1;
			[FieldOffset(1)] public byte d2;
			[FieldOffset(2)] public byte d3;
			[FieldOffset(3)] public byte d4;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct RECT
		{
			[FieldOffset(0)] public int left;
			[FieldOffset(4)] public int top;
			[FieldOffset(8)] public int right;
			[FieldOffset(12)] public int bottom;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MATRIX
		{
			[FieldOffset(0)] public float m00;
			[FieldOffset(4)] public float m01;
			[FieldOffset(8)] public float m02;
			[FieldOffset(12)] public float m03;
			[FieldOffset(16)] public float m10;
			[FieldOffset(20)] public float m11;
			[FieldOffset(24)] public float m12;
			[FieldOffset(28)] public float m13;
			[FieldOffset(32)] public float m20;
			[FieldOffset(36)] public float m21;
			[FieldOffset(40)] public float m22;
			[FieldOffset(44)] public float m23;
			[FieldOffset(48)] public float m30;
			[FieldOffset(52)] public float m31;
			[FieldOffset(56)] public float m32;
			[FieldOffset(60)] public float m33;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLORDATA
		{
			[FieldOffset(0)] public short ColorBitDepth;
			[FieldOffset(2)] public short PixelByte;
			[FieldOffset(4)] public byte RedWidth ;
			[FieldOffset(5)] public byte GreenWidth ;
			[FieldOffset(6)] public byte BlueWidth ;
			[FieldOffset(7)] public byte AlphaWidth ;
			[FieldOffset(8)] public byte RedLoc ;
			[FieldOffset(9)] public byte GreenLoc ;
			[FieldOffset(10)] public byte BlueLoc ;
			[FieldOffset(11)] public byte AlphaLoc ;
			[FieldOffset(12)] public uint RedMask ;
			[FieldOffset(16)] public uint GreenMask ;
			[FieldOffset(20)] public uint BlueMask ;
			[FieldOffset(24)] public uint AlphaMask ;
			[FieldOffset(28)] public uint NoneMask ;
			[FieldOffset(32)] public COLORPALETTEDATA Palette ;
			[FieldOffset(1056)] public byte NoneLoc ;
			[FieldOffset(1057)] public byte NoneWidth ;
			[FieldOffset(1060)] public int Format ;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_COLL_RESULT_POLY
		{
			[FieldOffset(0)] public int HitFlag;
			[FieldOffset(4)] public VECTOR HitPosition;
			[FieldOffset(16)] public int FrameIndex;
			[FieldOffset(20)] public int PolyIndex;
			[FieldOffset(24)] public int MaterialIndex;
			[FieldOffset(28)] public VECTOR Position0;
			[FieldOffset(40)] public VECTOR Position1;
			[FieldOffset(52)] public VECTOR Position2;
			[FieldOffset(64)] public VECTOR Normal;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_REF_POLYGON
		{
			[FieldOffset(0)] public ushort FrameIndex;
			[FieldOffset(2)] public ushort MaterialIndex;
			[FieldOffset(4)] public int VIndexTarget;
			[FieldOffset(8)] public int VIndex0;
			[FieldOffset(12)] public int VIndex1;
			[FieldOffset(16)] public int VIndex2;
			[FieldOffset(20)] public VECTOR MinPosition;
			[FieldOffset(32)] public VECTOR MaxPosition;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_REF_VERTEX
		{
			[FieldOffset(0)] public VECTOR Position;
			[FieldOffset(12)] public VECTOR Normal;
			[FieldOffset(24)] public UV TexCoord0;
			[FieldOffset(32)] public UV TexCoord1;
			[FieldOffset(40)] public COLOR_U8 DiffuseColor;
			[FieldOffset(44)] public COLOR_U8 SpecularColor;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DINPUT_JOYSTATE
		{
			[FieldOffset(0)] public int X;
			[FieldOffset(4)] public int Y;
			[FieldOffset(8)] public int Z;
			[FieldOffset(12)] public int Rx;
			[FieldOffset(16)] public int Ry;
			[FieldOffset(20)] public int Rz;
			[FieldOffset(24)] public int Slider0;
			[FieldOffset(28)] public int Slider1;
			[FieldOffset(32)] public uint POV0;
			[FieldOffset(36)] public uint POV1;
			[FieldOffset(40)] public uint POV2;
			[FieldOffset(44)] public uint POV3;
			[FieldOffset(48)] public byte Buttons0;
			[FieldOffset(49)] public byte Buttons1;
			[FieldOffset(50)] public byte Buttons2;
			[FieldOffset(51)] public byte Buttons3;
			[FieldOffset(52)] public byte Buttons4;
			[FieldOffset(53)] public byte Buttons5;
			[FieldOffset(54)] public byte Buttons6;
			[FieldOffset(55)] public byte Buttons7;
			[FieldOffset(56)] public byte Buttons8;
			[FieldOffset(57)] public byte Buttons9;
			[FieldOffset(58)] public byte Buttons10;
			[FieldOffset(59)] public byte Buttons11;
			[FieldOffset(60)] public byte Buttons12;
			[FieldOffset(61)] public byte Buttons13;
			[FieldOffset(62)] public byte Buttons14;
			[FieldOffset(63)] public byte Buttons15;
			[FieldOffset(64)] public byte Buttons16;
			[FieldOffset(65)] public byte Buttons17;
			[FieldOffset(66)] public byte Buttons18;
			[FieldOffset(67)] public byte Buttons19;
			[FieldOffset(68)] public byte Buttons20;
			[FieldOffset(69)] public byte Buttons21;
			[FieldOffset(70)] public byte Buttons22;
			[FieldOffset(71)] public byte Buttons23;
			[FieldOffset(72)] public byte Buttons24;
			[FieldOffset(73)] public byte Buttons25;
			[FieldOffset(74)] public byte Buttons26;
			[FieldOffset(75)] public byte Buttons27;
			[FieldOffset(76)] public byte Buttons28;
			[FieldOffset(77)] public byte Buttons29;
			[FieldOffset(78)] public byte Buttons30;
			[FieldOffset(79)] public byte Buttons31;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IMEINPUTCLAUSEDATA
		{
			[FieldOffset(0)] public int  Position;
			[FieldOffset(4)] public int  Length;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IMEINPUTDATA
		{
			[FieldOffset(0)] public uint  InputString;
			[FieldOffset(4)] public int  CursorPosition;
			[FieldOffset(8)] public uint  ClauseData;
			[FieldOffset(12)] public int  ClauseNum;
			[FieldOffset(16)] public int  SelectClause;
			[FieldOffset(20)] public int  CandidateNum;
			[FieldOffset(24)] public uint  CandidateList;
			[FieldOffset(28)] public int  SelectCandidate;
			[FieldOffset(32)] public int  ConvertFlag;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DATEDATA
		{
			[FieldOffset(0)] public int  Year;
			[FieldOffset(4)] public int  Mon;
			[FieldOffset(8)] public int  Day;
			[FieldOffset(12)] public int  Hour;
			[FieldOffset(16)] public int  Min;
			[FieldOffset(20)] public int  Sec;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DISPLAYMODEDATA
		{
			[FieldOffset(0)] public int  Width;
			[FieldOffset(4)] public int  Height;
			[FieldOffset(8)] public int  ColorBitDepth;
			[FieldOffset(12)] public int  RefreshRate;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VECTOR
		{
			[FieldOffset(0)] public float  x;
			[FieldOffset(4)] public float  y;
			[FieldOffset(8)] public float  z;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct UV
		{
			[FieldOffset(0)] public float  u;
			[FieldOffset(4)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLOR_F
		{
			[FieldOffset(0)] public float  r;
			[FieldOffset(4)] public float  g;
			[FieldOffset(8)] public float  b;
			[FieldOffset(12)] public float  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLOR_U8
		{
			[FieldOffset(0)] public byte  b;
			[FieldOffset(1)] public byte  g;
			[FieldOffset(2)] public byte  r;
			[FieldOffset(3)] public byte  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct FLOAT4
		{
			[FieldOffset(0)] public float  x;
			[FieldOffset(4)] public float  y;
			[FieldOffset(8)] public float  z;
			[FieldOffset(12)] public float  w;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct INT4
		{
			[FieldOffset(0)] public int  x;
			[FieldOffset(4)] public int  y;
			[FieldOffset(8)] public int  z;
			[FieldOffset(12)] public int  w;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX_NOTEX_2D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public int  color;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX_2D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public int  color;
			[FieldOffset(20)] public float  u;
			[FieldOffset(24)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX2D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public COLOR_U8  dif;
			[FieldOffset(20)] public float  u;
			[FieldOffset(24)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX2DSHADER
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public COLOR_U8  dif;
			[FieldOffset(20)] public COLOR_U8  spc;
			[FieldOffset(24)] public float  u;
			[FieldOffset(28)] public float  v;
			[FieldOffset(32)] public float  su;
			[FieldOffset(36)] public float  sv;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX
		{
			[FieldOffset(0)] public float  x;
			[FieldOffset(4)] public float  y;
			[FieldOffset(8)] public float  u;
			[FieldOffset(12)] public float  v;
			[FieldOffset(16)] public byte  b;
			[FieldOffset(17)] public byte  g;
			[FieldOffset(18)] public byte  r;
			[FieldOffset(19)] public byte  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX_NOTEX_3D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public byte  b;
			[FieldOffset(13)] public byte  g;
			[FieldOffset(14)] public byte  r;
			[FieldOffset(15)] public byte  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX_3D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public byte  b;
			[FieldOffset(13)] public byte  g;
			[FieldOffset(14)] public byte  r;
			[FieldOffset(15)] public byte  a;
			[FieldOffset(16)] public float  u;
			[FieldOffset(20)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX3D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public VECTOR  norm;
			[FieldOffset(24)] public COLOR_U8  dif;
			[FieldOffset(28)] public COLOR_U8  spc;
			[FieldOffset(32)] public float  u;
			[FieldOffset(36)] public float  v;
			[FieldOffset(40)] public float  su;
			[FieldOffset(44)] public float  sv;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX3DSHADER
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public VECTOR  norm;
			[FieldOffset(24)] public COLOR_U8  dif;
			[FieldOffset(28)] public COLOR_U8  spc;
			[FieldOffset(32)] public float  u;
			[FieldOffset(36)] public float  v;
			[FieldOffset(40)] public float  su;
			[FieldOffset(44)] public float  sv;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct LIGHTPARAM
		{
			[FieldOffset(0)] public int  LightType;
			[FieldOffset(4)] public COLOR_F  Diffuse;
			[FieldOffset(20)] public COLOR_F  Specular;
			[FieldOffset(36)] public COLOR_F  Ambient;
			[FieldOffset(52)] public VECTOR  Position;
			[FieldOffset(64)] public VECTOR  Direction;
			[FieldOffset(76)] public float  Range;
			[FieldOffset(80)] public float  Falloff;
			[FieldOffset(84)] public float  Attenuation0;
			[FieldOffset(88)] public float  Attenuation1;
			[FieldOffset(92)] public float  Attenuation2;
			[FieldOffset(96)] public float  Theta;
			[FieldOffset(100)] public float  Phi;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MATERIALPARAM
		{
			[FieldOffset(0)] public COLOR_F  Diffuse;
			[FieldOffset(16)] public COLOR_F  Ambient;
			[FieldOffset(32)] public COLOR_F  Specular;
			[FieldOffset(48)] public COLOR_F  Emissive;
			[FieldOffset(64)] public float  Power;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct HITRESULT_LINE
		{
			[FieldOffset(0)] public int  HitFlag;
			[FieldOffset(4)] public VECTOR  Position;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_COLL_RESULT_POLY_DIM
		{
			[FieldOffset(0)] public int  HitNum;
			[FieldOffset(4)] public uint  Dim;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_REF_POLYGONLIST
		{
			[FieldOffset(0)] public int  PolygonNum;
			[FieldOffset(4)] public int  VertexNum;
			[FieldOffset(8)] public VECTOR  MinPosition;
			[FieldOffset(20)] public VECTOR  MaxPosition;
			[FieldOffset(32)] public uint  Polygons;
			[FieldOffset(36)] public uint  Vertexs;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MEMSTREAMDATA
		{
			[FieldOffset(0)] public uint  DataBuffer;
			[FieldOffset(4)] public uint  DataSize;
			[FieldOffset(8)] public int  DataPoint;
			[FieldOffset(12)] public int  EOFFlag;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLORPALETTEDATA
		{
			[FieldOffset(0)] public byte  Blue;
			[FieldOffset(1)] public byte  Green;
			[FieldOffset(2)] public byte  Red;
			[FieldOffset(3)] public byte  Alpha;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct BASEIMAGE
		{
			[FieldOffset(0)] public COLORDATA  ColorData;
			[FieldOffset(1064)] public int  Width;
			[FieldOffset(1068)] public int  Height;
			[FieldOffset(1072)] public int  Pitch;
			[FieldOffset(1076)] public uint  GraphData;
			[FieldOffset(1080)] public int  MipMapCount;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct LINEDATA
		{
			[FieldOffset(0)] public int  x1;
			[FieldOffset(4)] public int  y1;
			[FieldOffset(8)] public int  x2;
			[FieldOffset(12)] public int  y2;
			[FieldOffset(16)] public int  color;
			[FieldOffset(20)] public int  pal;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct POINTDATA
		{
			[FieldOffset(0)] public int  x;
			[FieldOffset(4)] public int  y;
			[FieldOffset(8)] public int  color;
			[FieldOffset(12)] public int  pal;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IMAGEFORMATDESC
		{
			[FieldOffset(0)] public byte  TextureFlag;
			[FieldOffset(1)] public byte  AlphaChFlag;
			[FieldOffset(2)] public byte  DrawValidFlag;
			[FieldOffset(3)] public byte  SystemMemFlag;
			[FieldOffset(4)] public byte  NotManagedTextureFlag;
			[FieldOffset(5)] public byte  BaseFormat;
			[FieldOffset(6)] public byte  MipMapCount;
			[FieldOffset(7)] public byte  AlphaTestFlag;
			[FieldOffset(8)] public byte  ColorBitDepth;
			[FieldOffset(9)] public byte  BlendGraphFlag;
			[FieldOffset(10)] public byte  UsePaletteFlag;
			[FieldOffset(11)] public byte  MSSamples;
			[FieldOffset(12)] public byte  MSQuality;
		};


		public static VECTOR VGet( float x, float y, float z )
		{
			VECTOR Result ;
			Result.x = x ;
			Result.y = y ;
			Result.z = z ;
			return Result ;
		}

		public static VECTOR VAdd( VECTOR In1, VECTOR In2 )
		{
			VECTOR Result ;
			Result.x = In1.x + In2.x ;
			Result.y = In1.y + In2.y ;
			Result.z = In1.z + In2.z ;
			return Result ;
		}

		public static VECTOR VSub( VECTOR In1, VECTOR In2 )
		{
			VECTOR Result ;
			Result.x = In1.x - In2.x ;
			Result.y = In1.y - In2.y ;
			Result.z = In1.z - In2.z ;
			return Result ;
		}

		public static float VDot( VECTOR In1, VECTOR In2 )
		{
			return In1.x * In2.x + In1.y * In2.y + In1.z * In2.z ;
		}

		public static VECTOR VCross( VECTOR In1, VECTOR In2 )
		{
			VECTOR Result ;
			Result.x = In1.y * In2.z - In1.z * In2.y ;
			Result.y = In1.z * In2.x - In1.x * In2.z ;
			Result.z = In1.x * In2.y - In1.y * In2.x ;
			return Result ;
		}

		public static VECTOR VScale( VECTOR In, float Scale )
		{
			VECTOR Result ;
			Result.x = In.x * Scale ;
			Result.y = In.y * Scale ;
			Result.z = In.z * Scale ;
			return Result ;
		}

		public static float VSquareSize( VECTOR In )
		{
			return In.x * In.x + In.y * In.y + In.z * In.z ;
		}

		public static VECTOR VTransform( VECTOR InV, MATRIX InM )
		{
			VECTOR Result ;
			Result.x = InV.x * InM.m00 + InV.y * InM.m10 + InV.z * InM.m20 + InM.m30 ;
			Result.y = InV.x * InM.m01 + InV.y * InM.m11 + InV.z * InM.m21 + InM.m31 ;
			Result.z = InV.x * InM.m02 + InV.y * InM.m12 + InV.z * InM.m22 + InM.m32 ;
			return Result ;
		}

		public static VECTOR VTransformSR( VECTOR InV, MATRIX InM )
		{
			VECTOR Result ;
			Result.x = InV.x * InM.m00 + InV.y * InM.m10 + InV.z * InM.m20 ;
			Result.y = InV.x * InM.m01 + InV.y * InM.m11 + InV.z * InM.m21 ;
			Result.z = InV.x * InM.m02 + InV.y * InM.m12 + InV.z * InM.m22 ;
			return Result ;
		}



#if DX_USE_UNSAFE
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate int SetActiveStateChangeCallBackFunctionCallback(int ActiveState, void* UserData);
		[DllImport("DxLib.dll", EntryPoint = "dx_SetActiveStateChangeCallBackFunction")]
		extern unsafe static int dx_SetActiveStateChangeCallBackFunction(SetActiveStateChangeCallBackFunctionCallback Callback, void* UserData);
		public unsafe static int SetActiveStateChangeCallBackFunction(SetActiveStateChangeCallBackFunctionCallback Callback, void* UserData)
		{
			return dx_SetActiveStateChangeCallBackFunction(Callback, UserData);
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetUseASyncChangeWindowModeFunctionCallback( void *Data );
		[DllImport("DxLib.dll", EntryPoint = "dx_SetUseASyncChangeWindowModeFunction")]
		extern unsafe static int dx_SetUseASyncChangeWindowModeFunction( int Flag , SetUseASyncChangeWindowModeFunctionCallback CallBackFunction, void *Data );
		public unsafe static int SetUseASyncChangeWindowModeFunction( int Flag , SetUseASyncChangeWindowModeFunctionCallback CallBackFunction, void *Data )
		{
			return dx_SetUseASyncChangeWindowModeFunction( Flag , CallBackFunction, Data );
		}
#endif
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetMenuItemSelectCallBackFunctionCallback( string ItemName, int ItemID );
		[DllImport("DxLib.dll", EntryPoint = "dx_SetMenuItemSelectCallBackFunction")]
		extern static int dx_SetMenuItemSelectCallBackFunction( SetMenuItemSelectCallBackFunctionCallback CallBackFunction );
		public static int SetMenuItemSelectCallBackFunction( SetMenuItemSelectCallBackFunctionCallback CallBackFunction )
		{
			return dx_SetMenuItemSelectCallBackFunction( CallBackFunction );
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetWindowMenuCallback( ushort ID );
		[DllImport("DxLib.dll", EntryPoint = "dx_SetWindowMenu")]
		extern static int dx_SetWindowMenu( int MenuID, SetWindowMenuCallback MenuProc );
		public static int SetWindowMenu( int MenuID, SetWindowMenuCallback MenuProc )
		{
			return dx_SetWindowMenu( MenuID, MenuProc );
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetRestoreShredPointCallback();
		[DllImport("DxLib.dll", EntryPoint = "dx_SetRestoreShredPoint")]
		extern static int dx_SetRestoreShredPoint( SetRestoreShredPointCallback ShredPoint );
		public static int SetRestoreShredPoint( SetRestoreShredPointCallback ShredPoint )
		{
			return dx_SetRestoreShredPoint( ShredPoint );
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetRestoreGraphCallbackCallback();
		[DllImport("DxLib.dll", EntryPoint = "dx_SetRestoreGraphCallback")]
		extern static int dx_SetRestoreGraphCallback( SetRestoreGraphCallbackCallback Callback );
		public static int SetRestoreGraphCallback( SetRestoreGraphCallbackCallback Callback )
		{
			return dx_SetRestoreGraphCallback( Callback );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClearDrawScreen")]
		extern static int  dx_ClearDrawScreen( out RECT  ClearRect);
		public static int  ClearDrawScreen( out RECT  ClearRect)
		{
			return dx_ClearDrawScreen( out ClearRect );
		}
		public static int  ClearDrawScreen()
		{
		    RECT temp;
		
		    temp.left = -1;
		    temp.top = -1;
		    temp.right = -1;
		    temp.bottom = -1;
		    return dx_ClearDrawScreen( out temp );
		}
		
		[DllImport("DxLib.dll", EntryPoint="dx_ClearDrawScreenZBuffer")]
		extern static int  dx_ClearDrawScreenZBuffer( out RECT  ClearRect);
		public static int  ClearDrawScreenZBuffer( out RECT  ClearRect)
		{
			return dx_ClearDrawScreenZBuffer( out ClearRect );
		}
		public static int ClearDrawScreenZBuffer()
		{
		    RECT temp;
		
		    temp.left = -1;
		    temp.top = -1;
		    temp.right = -1;
		    temp.bottom = -1;
		    return dx_ClearDrawScreenZBuffer( out temp );
		}
		
		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputStringColor")]
		extern static int  dx_SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF, ulong  SelectStrBackColor, ulong  SelectStrColor, ulong  SelectStrEdgeColor);
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr)
		{
			return dx_SetKeyInputStringColor( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , 0 , 0 , 0 , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE)
		{
			return dx_SetKeyInputStringColor( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , 0 , 0 , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE)
		{
			return dx_SetKeyInputStringColor( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , 0 , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE)
		{
			return dx_SetKeyInputStringColor( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE)
		{
			return dx_SetKeyInputStringColor( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF)
		{
			return dx_SetKeyInputStringColor( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF, ulong  SelectStrBackColor)
		{
			return dx_SetKeyInputStringColor( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , SelectStrBackColor , 0xffffffffffffffff , 0xffffffffffffffff );
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF, ulong  SelectStrBackColor, ulong  SelectStrColor)
		{
			return dx_SetKeyInputStringColor( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , SelectStrBackColor , SelectStrColor , 0xffffffffffffffff );
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF, ulong  SelectStrBackColor, ulong  SelectStrColor, ulong  SelectStrEdgeColor)
		{
			return dx_SetKeyInputStringColor( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , SelectStrBackColor , SelectStrColor , SelectStrEdgeColor );
		}


		[DllImport("DxLib.dll", EntryPoint="dx_GraphFilterS")]
		extern static int  dx_GraphFilterS( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType)
		{
			return dx_GraphFilterS( GrHandle, FilterType, 0, 0, 0, 0, 0, 0 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GraphFilterBltS")]
		extern static int  dx_GraphFilterBltS( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, 0, 0, 0, 0, 0, 0);
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GraphFilterRectBltS")]
		extern static int  dx_GraphFilterRectBltS( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, 0, 0, 0, 0, 0, 0);
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GraphBlendS")]
		extern static int  dx_GraphBlendS( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GraphBlendBltS")]
		extern static int  dx_GraphBlendBltS( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GraphBlendRectBltS")]
		extern static int  dx_GraphBlendRectBltS( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
		}


		[DllImport("DxLib.dll", EntryPoint="dx_DxLib_Init")]
		extern static int  dx_DxLib_Init( );
		public static int  DxLib_Init( )
		{
			return dx_DxLib_Init( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxLib_End")]
		extern static int  dx_DxLib_End( );
		public static int  DxLib_End( )
		{
			return dx_DxLib_End( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxLib_GlobalStructInitialize")]
		extern static int  dx_DxLib_GlobalStructInitialize( );
		public static int  DxLib_GlobalStructInitialize( )
		{
			return dx_DxLib_GlobalStructInitialize( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxLib_IsInit")]
		extern static int  dx_DxLib_IsInit( );
		public static int  DxLib_IsInit( )
		{
			return dx_DxLib_IsInit( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ErrorLogAdd")]
		extern static int  dx_ErrorLogAdd( string  ErrorStr);
		public static int  ErrorLogAdd( string  ErrorStr)
		{
			return dx_ErrorLogAdd( ErrorStr );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ErrorLogTabAdd")]
		extern static int  dx_ErrorLogTabAdd( );
		public static int  ErrorLogTabAdd( )
		{
			return dx_ErrorLogTabAdd( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ErrorLogTabSub")]
		extern static int  dx_ErrorLogTabSub( );
		public static int  ErrorLogTabSub( )
		{
			return dx_ErrorLogTabSub( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseTimeStampFlag")]
		extern static int  dx_SetUseTimeStampFlag( int  UseFlag);
		public static int  SetUseTimeStampFlag( int  UseFlag)
		{
			return dx_SetUseTimeStampFlag( UseFlag );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DxAlloc")]
		extern unsafe static void *  dx_DxAlloc( uint  AllocSize, string  File, int  Line);
		public unsafe static void *  DxAlloc( uint  AllocSize)
		{
			return dx_DxAlloc( AllocSize , null , -1 );
		}
		public unsafe static void *  DxAlloc( uint  AllocSize, string  File)
		{
			return dx_DxAlloc( AllocSize , File , -1 );
		}
		public unsafe static void *  DxAlloc( uint  AllocSize, string  File, int  Line)
		{
			return dx_DxAlloc( AllocSize , File , Line );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DxCalloc")]
		extern unsafe static void *  dx_DxCalloc( uint  AllocSize, string  File, int  Line);
		public unsafe static void *  DxCalloc( uint  AllocSize)
		{
			return dx_DxCalloc( AllocSize , null , -1 );
		}
		public unsafe static void *  DxCalloc( uint  AllocSize, string  File)
		{
			return dx_DxCalloc( AllocSize , File , -1 );
		}
		public unsafe static void *  DxCalloc( uint  AllocSize, string  File, int  Line)
		{
			return dx_DxCalloc( AllocSize , File , Line );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DxRealloc")]
		extern unsafe static void *  dx_DxRealloc( void *  Memory, uint  AllocSize, string  File, int  Line);
		public unsafe static void *  DxRealloc( void *  Memory, uint  AllocSize)
		{
			return dx_DxRealloc( Memory , AllocSize , null , -1 );
		}
		public unsafe static void *  DxRealloc( void *  Memory, uint  AllocSize, string  File)
		{
			return dx_DxRealloc( Memory , AllocSize , File , -1 );
		}
		public unsafe static void *  DxRealloc( void *  Memory, uint  AllocSize, string  File, int  Line)
		{
			return dx_DxRealloc( Memory , AllocSize , File , Line );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DxFree")]
		extern unsafe static void  dx_DxFree( void *  Memory);
		public unsafe static void  DxFree( void *  Memory)
		{
			dx_DxFree( Memory );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_DxSetAllocSizeTrap")]
		extern static uint  dx_DxSetAllocSizeTrap( uint  Size);
		public static uint  DxSetAllocSizeTrap( uint  Size)
		{
			return dx_DxSetAllocSizeTrap( Size );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxSetAllocPrintFlag")]
		extern static int  dx_DxSetAllocPrintFlag( int  Flag);
		public static int  DxSetAllocPrintFlag( int  Flag)
		{
			return dx_DxSetAllocPrintFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxGetAllocSize")]
		extern static uint  dx_DxGetAllocSize( );
		public static uint  DxGetAllocSize( )
		{
			return dx_DxGetAllocSize( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxGetAllocNum")]
		extern static int  dx_DxGetAllocNum( );
		public static int  DxGetAllocNum( )
		{
			return dx_DxGetAllocNum( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxDumpAlloc")]
		extern static void  dx_DxDumpAlloc( );
		public static void  DxDumpAlloc( )
		{
			dx_DxDumpAlloc( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxErrorCheckAlloc")]
		extern static int  dx_DxErrorCheckAlloc( );
		public static int  DxErrorCheckAlloc( )
		{
			return dx_DxErrorCheckAlloc( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxSetAllocSizeOutFlag")]
		extern static int  dx_DxSetAllocSizeOutFlag( int  Flag);
		public static int  DxSetAllocSizeOutFlag( int  Flag)
		{
			return dx_DxSetAllocSizeOutFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxSetAllocMemoryErrorCheckFlag")]
		extern static int  dx_DxSetAllocMemoryErrorCheckFlag( int  Flag);
		public static int  DxSetAllocMemoryErrorCheckFlag( int  Flag)
		{
			return dx_DxSetAllocMemoryErrorCheckFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLogDrawOutFlag")]
		extern static int  dx_SetLogDrawOutFlag( int  DrawFlag);
		public static int  SetLogDrawOutFlag( int  DrawFlag)
		{
			return dx_SetLogDrawOutFlag( DrawFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLogDrawFlag")]
		extern static int  dx_GetLogDrawFlag( );
		public static int  GetLogDrawFlag( )
		{
			return dx_GetLogDrawFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_clsDx")]
		extern static int  dx_clsDx( );
		public static int  clsDx( )
		{
			return dx_clsDx( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_open")]
		extern static int  dx_FileRead_open( string  FilePath, int  ASync);
		public static int  FileRead_open( string  FilePath)
		{
			return dx_FileRead_open( FilePath , FALSE );
		}
		public static int  FileRead_open( string  FilePath, int  ASync)
		{
			return dx_FileRead_open( FilePath , ASync );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_size")]
		extern static int  dx_FileRead_size( string  FilePath);
		public static int  FileRead_size( string  FilePath)
		{
			return dx_FileRead_size( FilePath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_close")]
		extern static int  dx_FileRead_close( int  FileHandle);
		public static int  FileRead_close( int  FileHandle)
		{
			return dx_FileRead_close( FileHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_tell")]
		extern static int  dx_FileRead_tell( int  FileHandle);
		public static int  FileRead_tell( int  FileHandle)
		{
			return dx_FileRead_tell( FileHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_seek")]
		extern static int  dx_FileRead_seek( int  FileHandle, int  Offset, int  Origin);
		public static int  FileRead_seek( int  FileHandle, int  Offset, int  Origin)
		{
			return dx_FileRead_seek( FileHandle , Offset , Origin );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_read")]
		extern unsafe static int  dx_FileRead_read( void *  Buffer, int  ReadSize, int  FileHandle);
		public unsafe static int  FileRead_read( void *  Buffer, int  ReadSize, int  FileHandle)
		{
			return dx_FileRead_read( Buffer , ReadSize , FileHandle );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_idle_chk")]
		extern static int  dx_FileRead_idle_chk( int  FileHandle);
		public static int  FileRead_idle_chk( int  FileHandle)
		{
			return dx_FileRead_idle_chk( FileHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_eof")]
		extern static int  dx_FileRead_eof( int  FileHandle);
		public static int  FileRead_eof( int  FileHandle)
		{
			return dx_FileRead_eof( FileHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_gets")]
		extern static int  dx_FileRead_gets( System.Text.StringBuilder  Buffer, int  BufferSize, int  FileHandle);
		public static int  FileRead_gets( System.Text.StringBuilder  Buffer, int  BufferSize, int  FileHandle)
		{
			return dx_FileRead_gets( Buffer , BufferSize , FileHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_createInfo")]
		extern static int  dx_FileRead_createInfo( string  ObjectPath);
		public static int  FileRead_createInfo( string  ObjectPath)
		{
			return dx_FileRead_createInfo( ObjectPath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_getInfoNum")]
		extern static int  dx_FileRead_getInfoNum( int  FileInfoHandle);
		public static int  FileRead_getInfoNum( int  FileInfoHandle)
		{
			return dx_FileRead_getInfoNum( FileInfoHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_deleteInfo")]
		extern static int  dx_FileRead_deleteInfo( int  FileInfoHandle);
		public static int  FileRead_deleteInfo( int  FileInfoHandle)
		{
			return dx_FileRead_deleteInfo( FileInfoHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessMessage")]
		extern static int  dx_ProcessMessage( );
		public static int  ProcessMessage( )
		{
			return dx_ProcessMessage( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowCRect")]
		extern static int  dx_GetWindowCRect( out RECT  RectBuf);
		public static int  GetWindowCRect( out RECT  RectBuf)
		{
			return dx_GetWindowCRect( out RectBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowActiveFlag")]
		extern static int  dx_GetWindowActiveFlag( );
		public static int  GetWindowActiveFlag( )
		{
			return dx_GetWindowActiveFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowModeFlag")]
		extern static int  dx_GetWindowModeFlag( );
		public static int  GetWindowModeFlag( )
		{
			return dx_GetWindowModeFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDefaultState")]
		extern static int  dx_GetDefaultState( out int  SizeX, out int  SizeY, out int  ColorBitDepth);
		public static int  GetDefaultState( out int  SizeX, out int  SizeY, out int  ColorBitDepth)
		{
			return dx_GetDefaultState( out SizeX , out SizeY , out ColorBitDepth );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetActiveFlag")]
		extern static int  dx_GetActiveFlag( );
		public static int  GetActiveFlag( )
		{
			return dx_GetActiveFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNoActiveState")]
		extern static int  dx_GetNoActiveState( int  ResetFlag);
		public static int  GetNoActiveState( )
		{
			return dx_GetNoActiveState( TRUE );
		}
		public static int  GetNoActiveState( int  ResetFlag)
		{
			return dx_GetNoActiveState( ResetFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseDispFlag")]
		extern static int  dx_GetMouseDispFlag( );
		public static int  GetMouseDispFlag( )
		{
			return dx_GetMouseDispFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetAlwaysRunFlag")]
		extern static int  dx_GetAlwaysRunFlag( );
		public static int  GetAlwaysRunFlag( )
		{
			return dx_GetAlwaysRunFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx__GetSystemInfo")]
		extern static int  dx__GetSystemInfo( out int  DxLibVer, out int  DirectXVer, out int  WindowsVer);
		public static int  _GetSystemInfo( out int  DxLibVer, out int  DirectXVer, out int  WindowsVer)
		{
			return dx__GetSystemInfo( out DxLibVer , out DirectXVer , out WindowsVer );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPcInfo")]
		extern static int  dx_GetPcInfo( System.Text.StringBuilder  OSString, System.Text.StringBuilder  DirectXString, System.Text.StringBuilder  CPUString, out int  CPUSpeed, out double  FreeMemorySize, out double  TotalMemorySize, System.Text.StringBuilder  VideoDriverFileName, System.Text.StringBuilder  VideoDriverString, out double  FreeVideoMemorySize, out double  TotalVideoMemorySize);
		public static int  GetPcInfo( System.Text.StringBuilder  OSString, System.Text.StringBuilder  DirectXString, System.Text.StringBuilder  CPUString, out int  CPUSpeed, out double  FreeMemorySize, out double  TotalMemorySize, System.Text.StringBuilder  VideoDriverFileName, System.Text.StringBuilder  VideoDriverString, out double  FreeVideoMemorySize, out double  TotalVideoMemorySize)
		{
			return dx_GetPcInfo( OSString , DirectXString , CPUString , out CPUSpeed , out FreeMemorySize , out TotalMemorySize , VideoDriverFileName , VideoDriverString , out FreeVideoMemorySize , out TotalVideoMemorySize );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseMMXFlag")]
		extern static int  dx_GetUseMMXFlag( );
		public static int  GetUseMMXFlag( )
		{
			return dx_GetUseMMXFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseSSEFlag")]
		extern static int  dx_GetUseSSEFlag( );
		public static int  GetUseSSEFlag( )
		{
			return dx_GetUseSSEFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseSSE2Flag")]
		extern static int  dx_GetUseSSE2Flag( );
		public static int  GetUseSSE2Flag( )
		{
			return dx_GetUseSSE2Flag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowCloseFlag")]
		extern static int  dx_GetWindowCloseFlag( );
		public static int  GetWindowCloseFlag( )
		{
			return dx_GetWindowCloseFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseWindowRgnFlag")]
		extern static int  dx_GetUseWindowRgnFlag( );
		public static int  GetUseWindowRgnFlag( )
		{
			return dx_GetUseWindowRgnFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowSize")]
		extern static int  dx_GetWindowSize( out int  Width, out int  Height);
		public static int  GetWindowSize( out int  Width, out int  Height)
		{
			return dx_GetWindowSize( out Width , out Height );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowPosition")]
		extern static int  dx_GetWindowPosition( out int  x, out int  y);
		public static int  GetWindowPosition( out int  x, out int  y)
		{
			return dx_GetWindowPosition( out x , out y );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowUserCloseFlag")]
		extern static int  dx_GetWindowUserCloseFlag( int  StateResetFlag);
		public static int  GetWindowUserCloseFlag( )
		{
			return dx_GetWindowUserCloseFlag( FALSE );
		}
		public static int  GetWindowUserCloseFlag( int  StateResetFlag)
		{
			return dx_GetWindowUserCloseFlag( StateResetFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNotDrawFlag")]
		extern static int  dx_GetNotDrawFlag( );
		public static int  GetNotDrawFlag( )
		{
			return dx_GetNotDrawFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPaintMessageFlag")]
		extern static int  dx_GetPaintMessageFlag( );
		public static int  GetPaintMessageFlag( )
		{
			return dx_GetPaintMessageFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetValidHiPerformanceCounter")]
		extern static int  dx_GetValidHiPerformanceCounter( );
		public static int  GetValidHiPerformanceCounter( )
		{
			return dx_GetValidHiPerformanceCounter( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeWindowMode")]
		extern static int  dx_ChangeWindowMode( int  Flag);
		public static int  ChangeWindowMode( int  Flag)
		{
			return dx_ChangeWindowMode( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseCharSet")]
		extern static int  dx_SetUseCharSet( int  CharSet);
		public static int  SetUseCharSet( int  CharSet)
		{
			return dx_SetUseCharSet( CharSet );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadPauseGraph")]
		extern static int  dx_LoadPauseGraph( string  FileName);
		public static int  LoadPauseGraph( string  FileName)
		{
			return dx_LoadPauseGraph( FileName );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadPauseGraphFromMem")]
		extern unsafe static int  dx_LoadPauseGraphFromMem( void *  MemImage, int  MemImageSize);
		public unsafe static int  LoadPauseGraphFromMem( void *  MemImage, int  MemImageSize)
		{
			return dx_LoadPauseGraphFromMem( MemImage , MemImageSize );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowText")]
		extern static int  dx_SetWindowText( string  WindowText);
		public static int  SetWindowText( string  WindowText)
		{
			return dx_SetWindowText( WindowText );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMainWindowText")]
		extern static int  dx_SetMainWindowText( string  WindowText);
		public static int  SetMainWindowText( string  WindowText)
		{
			return dx_SetMainWindowText( WindowText );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMainWindowClassName")]
		extern static int  dx_SetMainWindowClassName( string  ClassName);
		public static int  SetMainWindowClassName( string  ClassName)
		{
			return dx_SetMainWindowClassName( ClassName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetOutApplicationLogValidFlag")]
		extern static int  dx_SetOutApplicationLogValidFlag( int  Flag);
		public static int  SetOutApplicationLogValidFlag( int  Flag)
		{
			return dx_SetOutApplicationLogValidFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetApplicationLogSaveDirectory")]
		extern static int  dx_SetApplicationLogSaveDirectory( string  DirectoryPath);
		public static int  SetApplicationLogSaveDirectory( string  DirectoryPath)
		{
			return dx_SetApplicationLogSaveDirectory( DirectoryPath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetAlwaysRunFlag")]
		extern static int  dx_SetAlwaysRunFlag( int  Flag);
		public static int  SetAlwaysRunFlag( int  Flag)
		{
			return dx_SetAlwaysRunFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowIconID")]
		extern static int  dx_SetWindowIconID( int  ID);
		public static int  SetWindowIconID( int  ID)
		{
			return dx_SetWindowIconID( ID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowStyleMode")]
		extern static int  dx_SetWindowStyleMode( int  Mode);
		public static int  SetWindowStyleMode( int  Mode)
		{
			return dx_SetWindowStyleMode( Mode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowSizeChangeEnableFlag")]
		extern static int  dx_SetWindowSizeChangeEnableFlag( int  Flag, int  FitScreen);
		public static int  SetWindowSizeChangeEnableFlag( int  Flag)
		{
			return dx_SetWindowSizeChangeEnableFlag( Flag , TRUE );
		}
		public static int  SetWindowSizeChangeEnableFlag( int  Flag, int  FitScreen)
		{
			return dx_SetWindowSizeChangeEnableFlag( Flag , FitScreen );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowSizeExtendRate")]
		extern static int  dx_SetWindowSizeExtendRate( double  ExRateX, double  ExRateY);
		public static int  SetWindowSizeExtendRate( double  ExRateX)
		{
			return dx_SetWindowSizeExtendRate( ExRateX , -1.0 );
		}
		public static int  SetWindowSizeExtendRate( double  ExRateX, double  ExRateY)
		{
			return dx_SetWindowSizeExtendRate( ExRateX , ExRateY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowSize")]
		extern static int  dx_SetWindowSize( int  Width, int  Height);
		public static int  SetWindowSize( int  Width, int  Height)
		{
			return dx_SetWindowSize( Width , Height );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowPosition")]
		extern static int  dx_SetWindowPosition( int  x, int  y);
		public static int  SetWindowPosition( int  x, int  y)
		{
			return dx_SetWindowPosition( x , y );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetSysCommandOffFlag")]
		extern static int  dx_SetSysCommandOffFlag( int  Flag, string  HookDllPath);
		public static int  SetSysCommandOffFlag( int  Flag)
		{
			return dx_SetSysCommandOffFlag( Flag , null );
		}
		public static int  SetSysCommandOffFlag( int  Flag, string  HookDllPath)
		{
			return dx_SetSysCommandOffFlag( Flag , HookDllPath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDoubleStartValidFlag")]
		extern static int  dx_SetDoubleStartValidFlag( int  Flag);
		public static int  SetDoubleStartValidFlag( int  Flag)
		{
			return dx_SetDoubleStartValidFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMessageTakeOverWindow")]
		extern static int  dx_AddMessageTakeOverWindow( System.IntPtr  Window);
		public static int  AddMessageTakeOverWindow( System.IntPtr  Window)
		{
			return dx_AddMessageTakeOverWindow( Window );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SubMessageTakeOverWindow")]
		extern static int  dx_SubMessageTakeOverWindow( System.IntPtr  Window);
		public static int  SubMessageTakeOverWindow( System.IntPtr  Window)
		{
			return dx_SubMessageTakeOverWindow( Window );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowInitPosition")]
		extern static int  dx_SetWindowInitPosition( int  x, int  y);
		public static int  SetWindowInitPosition( int  x, int  y)
		{
			return dx_SetWindowInitPosition( x , y );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotWinFlag")]
		extern static int  dx_SetNotWinFlag( int  Flag);
		public static int  SetNotWinFlag( int  Flag)
		{
			return dx_SetNotWinFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotDrawFlag")]
		extern static int  dx_SetNotDrawFlag( int  Flag);
		public static int  SetNotDrawFlag( int  Flag)
		{
			return dx_SetNotDrawFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotSoundFlag")]
		extern static int  dx_SetNotSoundFlag( int  Flag);
		public static int  SetNotSoundFlag( int  Flag)
		{
			return dx_SetNotSoundFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotInputFlag")]
		extern static int  dx_SetNotInputFlag( int  Flag);
		public static int  SetNotInputFlag( int  Flag)
		{
			return dx_SetNotInputFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDialogBoxHandle")]
		extern static int  dx_SetDialogBoxHandle( System.IntPtr  WindowHandle);
		public static int  SetDialogBoxHandle( System.IntPtr  WindowHandle)
		{
			return dx_SetDialogBoxHandle( WindowHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStreamFunctionDefault")]
		extern static int  dx_GetStreamFunctionDefault( );
		public static int  GetStreamFunctionDefault( )
		{
			return dx_GetStreamFunctionDefault( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowVisibleFlag")]
		extern static int  dx_SetWindowVisibleFlag( int  Flag);
		public static int  SetWindowVisibleFlag( int  Flag)
		{
			return dx_SetWindowVisibleFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowUserCloseEnableFlag")]
		extern static int  dx_SetWindowUserCloseEnableFlag( int  Flag);
		public static int  SetWindowUserCloseEnableFlag( int  Flag)
		{
			return dx_SetWindowUserCloseEnableFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDxLibEndPostQuitMessageFlag")]
		extern static int  dx_SetDxLibEndPostQuitMessageFlag( int  Flag);
		public static int  SetDxLibEndPostQuitMessageFlag( int  Flag)
		{
			return dx_SetDxLibEndPostQuitMessageFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUserWindow")]
		extern static int  dx_SetUserWindow( System.IntPtr  WindowHandle);
		public static int  SetUserWindow( System.IntPtr  WindowHandle)
		{
			return dx_SetUserWindow( WindowHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUserWindowMessageProcessDXLibFlag")]
		extern static int  dx_SetUserWindowMessageProcessDXLibFlag( int  Flag);
		public static int  SetUserWindowMessageProcessDXLibFlag( int  Flag)
		{
			return dx_SetUserWindowMessageProcessDXLibFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDXArchiveFlag")]
		extern static int  dx_SetUseDXArchiveFlag( int  Flag);
		public static int  SetUseDXArchiveFlag( int  Flag)
		{
			return dx_SetUseDXArchiveFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDXArchivePriority")]
		extern static int  dx_SetDXArchivePriority( int  Priority);
		public static int  SetDXArchivePriority( )
		{
			return dx_SetDXArchivePriority( 0 );
		}
		public static int  SetDXArchivePriority( int  Priority)
		{
			return dx_SetDXArchivePriority( Priority );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDXArchiveExtension")]
		extern static int  dx_SetDXArchiveExtension( string  Extension);
		public static int  SetDXArchiveExtension( )
		{
			return dx_SetDXArchiveExtension( null );
		}
		public static int  SetDXArchiveExtension( string  Extension)
		{
			return dx_SetDXArchiveExtension( Extension );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDXArchiveKeyString")]
		extern static int  dx_SetDXArchiveKeyString( string  KeyString);
		public static int  SetDXArchiveKeyString( )
		{
			return dx_SetDXArchiveKeyString( null );
		}
		public static int  SetDXArchiveKeyString( string  KeyString)
		{
			return dx_SetDXArchiveKeyString( KeyString );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDateNameLogFile")]
		extern static int  dx_SetUseDateNameLogFile( int  Flag);
		public static int  SetUseDateNameLogFile( int  Flag)
		{
			return dx_SetUseDateNameLogFile( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBackgroundColor")]
		extern static int  dx_SetBackgroundColor( int  Red, int  Green, int  Blue);
		public static int  SetBackgroundColor( int  Red, int  Green, int  Blue)
		{
			return dx_SetBackgroundColor( Red , Green , Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLogFontSize")]
		extern static int  dx_SetLogFontSize( int  Size);
		public static int  SetLogFontSize( int  Size)
		{
			return dx_SetLogFontSize( Size );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseFPUPreserveFlag")]
		extern static int  dx_SetUseFPUPreserveFlag( int  Flag);
		public static int  SetUseFPUPreserveFlag( int  Flag)
		{
			return dx_SetUseFPUPreserveFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetValidMousePointerWindowOutClientAreaMoveFlag")]
		extern static int  dx_SetValidMousePointerWindowOutClientAreaMoveFlag( int  Flag);
		public static int  SetValidMousePointerWindowOutClientAreaMoveFlag( int  Flag)
		{
			return dx_SetValidMousePointerWindowOutClientAreaMoveFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseBackBufferTransColorFlag")]
		extern static int  dx_SetUseBackBufferTransColorFlag( int  Flag);
		public static int  SetUseBackBufferTransColorFlag( int  Flag)
		{
			return dx_SetUseBackBufferTransColorFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetClipboardText")]
		extern static int  dx_GetClipboardText( System.Text.StringBuilder  DestBuffer);
		public static int  GetClipboardText( System.Text.StringBuilder  DestBuffer)
		{
			return dx_GetClipboardText( DestBuffer );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetClipboardText")]
		extern static int  dx_SetClipboardText( string  Text);
		public static int  SetClipboardText( string  Text)
		{
			return dx_SetClipboardText( Text );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDragFileValidFlag")]
		extern static int  dx_SetDragFileValidFlag( int  Flag);
		public static int  SetDragFileValidFlag( int  Flag)
		{
			return dx_SetDragFileValidFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DragFileInfoClear")]
		extern static int  dx_DragFileInfoClear( );
		public static int  DragFileInfoClear( )
		{
			return dx_DragFileInfoClear( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDragFilePath")]
		extern static int  dx_GetDragFilePath( System.Text.StringBuilder  FilePathBuffer);
		public static int  GetDragFilePath( System.Text.StringBuilder  FilePathBuffer)
		{
			return dx_GetDragFilePath( FilePathBuffer );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDragFileNum")]
		extern static int  dx_GetDragFileNum( );
		public static int  GetDragFileNum( )
		{
			return dx_GetDragFileNum( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowRgnGraph")]
		extern static int  dx_SetWindowRgnGraph( string  FileName);
		public static int  SetWindowRgnGraph( string  FileName)
		{
			return dx_SetWindowRgnGraph( FileName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_UpdateTransColorWindowRgn")]
		extern static int  dx_UpdateTransColorWindowRgn( );
		public static int  UpdateTransColorWindowRgn( )
		{
			return dx_UpdateTransColorWindowRgn( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupToolBar")]
		extern static int  dx_SetupToolBar( string  BitmapName, int  DivNum, int  ResourceID);
		public static int  SetupToolBar( string  BitmapName, int  DivNum)
		{
			return dx_SetupToolBar( BitmapName , DivNum , -1 );
		}
		public static int  SetupToolBar( string  BitmapName, int  DivNum, int  ResourceID)
		{
			return dx_SetupToolBar( BitmapName , DivNum , ResourceID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddToolBarButton")]
		extern static int  dx_AddToolBarButton( int  Type, int  State, int  ImageIndex, int  ID);
		public static int  AddToolBarButton( int  Type, int  State, int  ImageIndex, int  ID)
		{
			return dx_AddToolBarButton( Type , State , ImageIndex , ID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddToolBarSep")]
		extern static int  dx_AddToolBarSep( );
		public static int  AddToolBarSep( )
		{
			return dx_AddToolBarSep( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetToolBarButtonState")]
		extern static int  dx_GetToolBarButtonState( int  ID);
		public static int  GetToolBarButtonState( int  ID)
		{
			return dx_GetToolBarButtonState( ID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetToolBarButtonState")]
		extern static int  dx_SetToolBarButtonState( int  ID, int  State);
		public static int  SetToolBarButtonState( int  ID, int  State)
		{
			return dx_SetToolBarButtonState( ID , State );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteAllToolBarButton")]
		extern static int  dx_DeleteAllToolBarButton( );
		public static int  DeleteAllToolBarButton( )
		{
			return dx_DeleteAllToolBarButton( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseMenuFlag")]
		extern static int  dx_SetUseMenuFlag( int  Flag);
		public static int  SetUseMenuFlag( int  Flag)
		{
			return dx_SetUseMenuFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseKeyAccelFlag")]
		extern static int  dx_SetUseKeyAccelFlag( int  Flag);
		public static int  SetUseKeyAccelFlag( int  Flag)
		{
			return dx_SetUseKeyAccelFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddKeyAccel")]
		extern static int  dx_AddKeyAccel( string  ItemName, int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag);
		public static int  AddKeyAccel( string  ItemName, int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag)
		{
			return dx_AddKeyAccel( ItemName , ItemID , KeyCode , CtrlFlag , AltFlag , ShiftFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddKeyAccel_Name")]
		extern static int  dx_AddKeyAccel_Name( string  ItemName, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag);
		public static int  AddKeyAccel_Name( string  ItemName, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag)
		{
			return dx_AddKeyAccel_Name( ItemName , KeyCode , CtrlFlag , AltFlag , ShiftFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddKeyAccel_ID")]
		extern static int  dx_AddKeyAccel_ID( int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag);
		public static int  AddKeyAccel_ID( int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag)
		{
			return dx_AddKeyAccel_ID( ItemID , KeyCode , CtrlFlag , AltFlag , ShiftFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClearKeyAccel")]
		extern static int  dx_ClearKeyAccel( );
		public static int  ClearKeyAccel( )
		{
			return dx_ClearKeyAccel( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuItem")]
		extern static int  dx_AddMenuItem( int  AddType, string  ItemName, int  ItemID, int  SeparatorFlag, string  NewItemName, int  NewItemID);
		public static int  AddMenuItem( int  AddType, string  ItemName, int  ItemID, int  SeparatorFlag)
		{
			return dx_AddMenuItem( AddType , ItemName , ItemID , SeparatorFlag , null , -1 );
		}
		public static int  AddMenuItem( int  AddType, string  ItemName, int  ItemID, int  SeparatorFlag, string  NewItemName)
		{
			return dx_AddMenuItem( AddType , ItemName , ItemID , SeparatorFlag , NewItemName , -1 );
		}
		public static int  AddMenuItem( int  AddType, string  ItemName, int  ItemID, int  SeparatorFlag, string  NewItemName, int  NewItemID)
		{
			return dx_AddMenuItem( AddType , ItemName , ItemID , SeparatorFlag , NewItemName , NewItemID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMenuItem")]
		extern static int  dx_DeleteMenuItem( string  ItemName, int  ItemID);
		public static int  DeleteMenuItem( string  ItemName, int  ItemID)
		{
			return dx_DeleteMenuItem( ItemName , ItemID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMenuItemSelect")]
		extern static int  dx_CheckMenuItemSelect( string  ItemName, int  ItemID);
		public static int  CheckMenuItemSelect( string  ItemName, int  ItemID)
		{
			return dx_CheckMenuItemSelect( ItemName , ItemID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemEnable")]
		extern static int  dx_SetMenuItemEnable( string  ItemName, int  ItemID, int  EnableFlag);
		public static int  SetMenuItemEnable( string  ItemName, int  ItemID, int  EnableFlag)
		{
			return dx_SetMenuItemEnable( ItemName , ItemID , EnableFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemMark")]
		extern static int  dx_SetMenuItemMark( string  ItemName, int  ItemID, int  Mark);
		public static int  SetMenuItemMark( string  ItemName, int  ItemID, int  Mark)
		{
			return dx_SetMenuItemMark( ItemName , ItemID , Mark );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMenuItemSelectAll")]
		extern static int  dx_CheckMenuItemSelectAll( );
		public static int  CheckMenuItemSelectAll( )
		{
			return dx_CheckMenuItemSelectAll( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuItem_Name")]
		extern static int  dx_AddMenuItem_Name( string  ParentItemName, string  NewItemName);
		public static int  AddMenuItem_Name( string  ParentItemName, string  NewItemName)
		{
			return dx_AddMenuItem_Name( ParentItemName , NewItemName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuLine_Name")]
		extern static int  dx_AddMenuLine_Name( string  ParentItemName);
		public static int  AddMenuLine_Name( string  ParentItemName)
		{
			return dx_AddMenuLine_Name( ParentItemName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InsertMenuItem_Name")]
		extern static int  dx_InsertMenuItem_Name( string  ItemName, string  NewItemName);
		public static int  InsertMenuItem_Name( string  ItemName, string  NewItemName)
		{
			return dx_InsertMenuItem_Name( ItemName , NewItemName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InsertMenuLine_Name")]
		extern static int  dx_InsertMenuLine_Name( string  ItemName);
		public static int  InsertMenuLine_Name( string  ItemName)
		{
			return dx_InsertMenuLine_Name( ItemName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMenuItem_Name")]
		extern static int  dx_DeleteMenuItem_Name( string  ItemName);
		public static int  DeleteMenuItem_Name( string  ItemName)
		{
			return dx_DeleteMenuItem_Name( ItemName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMenuItemSelect_Name")]
		extern static int  dx_CheckMenuItemSelect_Name( string  ItemName);
		public static int  CheckMenuItemSelect_Name( string  ItemName)
		{
			return dx_CheckMenuItemSelect_Name( ItemName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemEnable_Name")]
		extern static int  dx_SetMenuItemEnable_Name( string  ItemName, int  EnableFlag);
		public static int  SetMenuItemEnable_Name( string  ItemName, int  EnableFlag)
		{
			return dx_SetMenuItemEnable_Name( ItemName , EnableFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemMark_Name")]
		extern static int  dx_SetMenuItemMark_Name( string  ItemName, int  Mark);
		public static int  SetMenuItemMark_Name( string  ItemName, int  Mark)
		{
			return dx_SetMenuItemMark_Name( ItemName , Mark );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuItem_ID")]
		extern static int  dx_AddMenuItem_ID( int  ParentItemID, string  NewItemName, int  NewItemID);
		public static int  AddMenuItem_ID( int  ParentItemID, string  NewItemName)
		{
			return dx_AddMenuItem_ID( ParentItemID , NewItemName , -1 );
		}
		public static int  AddMenuItem_ID( int  ParentItemID, string  NewItemName, int  NewItemID)
		{
			return dx_AddMenuItem_ID( ParentItemID , NewItemName , NewItemID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuLine_ID")]
		extern static int  dx_AddMenuLine_ID( int  ParentItemID);
		public static int  AddMenuLine_ID( int  ParentItemID)
		{
			return dx_AddMenuLine_ID( ParentItemID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InsertMenuItem_ID")]
		extern static int  dx_InsertMenuItem_ID( int  ItemID, int  NewItemID);
		public static int  InsertMenuItem_ID( int  ItemID, int  NewItemID)
		{
			return dx_InsertMenuItem_ID( ItemID , NewItemID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InsertMenuLine_ID")]
		extern static int  dx_InsertMenuLine_ID( int  ItemID, int  NewItemID);
		public static int  InsertMenuLine_ID( int  ItemID, int  NewItemID)
		{
			return dx_InsertMenuLine_ID( ItemID , NewItemID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMenuItem_ID")]
		extern static int  dx_DeleteMenuItem_ID( int  ItemID);
		public static int  DeleteMenuItem_ID( int  ItemID)
		{
			return dx_DeleteMenuItem_ID( ItemID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMenuItemSelect_ID")]
		extern static int  dx_CheckMenuItemSelect_ID( int  ItemID);
		public static int  CheckMenuItemSelect_ID( int  ItemID)
		{
			return dx_CheckMenuItemSelect_ID( ItemID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemEnable_ID")]
		extern static int  dx_SetMenuItemEnable_ID( int  ItemID, int  EnableFlag);
		public static int  SetMenuItemEnable_ID( int  ItemID, int  EnableFlag)
		{
			return dx_SetMenuItemEnable_ID( ItemID , EnableFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemMark_ID")]
		extern static int  dx_SetMenuItemMark_ID( int  ItemID, int  Mark);
		public static int  SetMenuItemMark_ID( int  ItemID, int  Mark)
		{
			return dx_SetMenuItemMark_ID( ItemID , Mark );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMenuItemAll")]
		extern static int  dx_DeleteMenuItemAll( );
		public static int  DeleteMenuItemAll( )
		{
			return dx_DeleteMenuItemAll( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClearMenuItemSelect")]
		extern static int  dx_ClearMenuItemSelect( );
		public static int  ClearMenuItemSelect( )
		{
			return dx_ClearMenuItemSelect( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMenuItemID")]
		extern static int  dx_GetMenuItemID( string  ItemName);
		public static int  GetMenuItemID( string  ItemName)
		{
			return dx_GetMenuItemID( ItemName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMenuItemName")]
		extern static int  dx_GetMenuItemName( int  ItemID, System.Text.StringBuilder  NameBuffer);
		public static int  GetMenuItemName( int  ItemID, System.Text.StringBuilder  NameBuffer)
		{
			return dx_GetMenuItemName( ItemID , NameBuffer );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadMenuResource")]
		extern static int  dx_LoadMenuResource( int  MenuResourceID);
		public static int  LoadMenuResource( int  MenuResourceID)
		{
			return dx_LoadMenuResource( MenuResourceID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDisplayMenuFlag")]
		extern static int  dx_SetDisplayMenuFlag( int  Flag);
		public static int  SetDisplayMenuFlag( int  Flag)
		{
			return dx_SetDisplayMenuFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDisplayMenuFlag")]
		extern static int  dx_GetDisplayMenuFlag( );
		public static int  GetDisplayMenuFlag( )
		{
			return dx_GetDisplayMenuFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseMenuFlag")]
		extern static int  dx_GetUseMenuFlag( );
		public static int  GetUseMenuFlag( )
		{
			return dx_GetUseMenuFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetAutoMenuDisplayFlag")]
		extern static int  dx_SetAutoMenuDisplayFlag( int  Flag);
		public static int  SetAutoMenuDisplayFlag( int  Flag)
		{
			return dx_SetAutoMenuDisplayFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMouseDispFlag")]
		extern static int  dx_SetMouseDispFlag( int  DispFlag);
		public static int  SetMouseDispFlag( int  DispFlag)
		{
			return dx_SetMouseDispFlag( DispFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMousePoint")]
		extern static int  dx_GetMousePoint( out int  XBuf, out int  YBuf);
		public static int  GetMousePoint( out int  XBuf, out int  YBuf)
		{
			return dx_GetMousePoint( out XBuf , out YBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMousePoint")]
		extern static int  dx_SetMousePoint( int  PointX, int  PointY);
		public static int  SetMousePoint( int  PointX, int  PointY)
		{
			return dx_SetMousePoint( PointX , PointY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseInput")]
		extern static int  dx_GetMouseInput( );
		public static int  GetMouseInput( )
		{
			return dx_GetMouseInput( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseWheelRotVol")]
		extern static int  dx_GetMouseWheelRotVol( int  CounterReset);
		public static int  GetMouseWheelRotVol( )
		{
			return dx_GetMouseWheelRotVol( TRUE );
		}
		public static int  GetMouseWheelRotVol( int  CounterReset)
		{
			return dx_GetMouseWheelRotVol( CounterReset );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseHWheelRotVol")]
		extern static int  dx_GetMouseHWheelRotVol( int  CounterReset);
		public static int  GetMouseHWheelRotVol( )
		{
			return dx_GetMouseHWheelRotVol( TRUE );
		}
		public static int  GetMouseHWheelRotVol( int  CounterReset)
		{
			return dx_GetMouseHWheelRotVol( CounterReset );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseInputLog")]
		extern static int  dx_GetMouseInputLog( out int  Button, out int  ClickX, out int  ClickY, int  LogDelete);
		public static int  GetMouseInputLog( out int  Button, out int  ClickX, out int  ClickY)
		{
			return dx_GetMouseInputLog( out Button , out ClickX , out ClickY , TRUE );
		}
		public static int  GetMouseInputLog( out int  Button, out int  ClickX, out int  ClickY, int  LogDelete)
		{
			return dx_GetMouseInputLog( out Button , out ClickX , out ClickY , LogDelete );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_WaitTimer")]
		extern static int  dx_WaitTimer( int  WaitTime);
		public static int  WaitTimer( int  WaitTime)
		{
			return dx_WaitTimer( WaitTime );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_WaitKey")]
		extern static int  dx_WaitKey( );
		public static int  WaitKey( )
		{
			return dx_WaitKey( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNowCount")]
		extern static int  dx_GetNowCount( int  UseRDTSCFlag);
		public static int  GetNowCount( )
		{
			return dx_GetNowCount( FALSE );
		}
		public static int  GetNowCount( int  UseRDTSCFlag)
		{
			return dx_GetNowCount( UseRDTSCFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNowHiPerformanceCount")]
		extern static long  dx_GetNowHiPerformanceCount( int  UseRDTSCFlag);
		public static long  GetNowHiPerformanceCount( )
		{
			return dx_GetNowHiPerformanceCount( FALSE );
		}
		public static long  GetNowHiPerformanceCount( int  UseRDTSCFlag)
		{
			return dx_GetNowHiPerformanceCount( UseRDTSCFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDateTime")]
		extern static int  dx_GetDateTime( out DATEDATA  DateBuf);
		public static int  GetDateTime( out DATEDATA  DateBuf)
		{
			return dx_GetDateTime( out DateBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetRand")]
		extern static int  dx_GetRand( int  RandMax);
		public static int  GetRand( int  RandMax)
		{
			return dx_GetRand( RandMax );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SRand")]
		extern static int  dx_SRand( int  Seed);
		public static int  SRand( int  Seed)
		{
			return dx_SRand( Seed );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessNetMessage")]
		extern static int  dx_ProcessNetMessage( int  RunReleaseProcess);
		public static int  ProcessNetMessage( )
		{
			return dx_ProcessNetMessage( FALSE );
		}
		public static int  ProcessNetMessage( int  RunReleaseProcess)
		{
			return dx_ProcessNetMessage( RunReleaseProcess );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetHostIPbyName")]
		extern unsafe static int  dx_GetHostIPbyName( string  HostName, IPDATA *  IPDataBuf);
		public unsafe static int  GetHostIPbyName( string  HostName, IPDATA *  IPDataBuf)
		{
			return dx_GetHostIPbyName( HostName , IPDataBuf );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetHostIPbyName_IPv6")]
		extern unsafe static int  dx_GetHostIPbyName_IPv6( string  HostName, IPDATA_IPv6 *  IPDataBuf);
		public unsafe static int  GetHostIPbyName_IPv6( string  HostName, IPDATA_IPv6 *  IPDataBuf)
		{
			return dx_GetHostIPbyName_IPv6( HostName , IPDataBuf );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_ConnectNetWork")]
		extern static int  dx_ConnectNetWork( IPDATA  IPData, int  Port);
		public static int  ConnectNetWork( IPDATA  IPData)
		{
			return dx_ConnectNetWork( IPData , -1 );
		}
		public static int  ConnectNetWork( IPDATA  IPData, int  Port)
		{
			return dx_ConnectNetWork( IPData , Port );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConnectNetWork_IPv6")]
		extern static int  dx_ConnectNetWork_IPv6( IPDATA_IPv6  IPData, int  Port);
		public static int  ConnectNetWork_IPv6( IPDATA_IPv6  IPData)
		{
			return dx_ConnectNetWork_IPv6( IPData , -1 );
		}
		public static int  ConnectNetWork_IPv6( IPDATA_IPv6  IPData, int  Port)
		{
			return dx_ConnectNetWork_IPv6( IPData , Port );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PreparationListenNetWork")]
		extern static int  dx_PreparationListenNetWork( int  Port);
		public static int  PreparationListenNetWork( )
		{
			return dx_PreparationListenNetWork( -1 );
		}
		public static int  PreparationListenNetWork( int  Port)
		{
			return dx_PreparationListenNetWork( Port );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PreparationListenNetWork_IPv6")]
		extern static int  dx_PreparationListenNetWork_IPv6( int  Port);
		public static int  PreparationListenNetWork_IPv6( )
		{
			return dx_PreparationListenNetWork_IPv6( -1 );
		}
		public static int  PreparationListenNetWork_IPv6( int  Port)
		{
			return dx_PreparationListenNetWork_IPv6( Port );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopListenNetWork")]
		extern static int  dx_StopListenNetWork( );
		public static int  StopListenNetWork( )
		{
			return dx_StopListenNetWork( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CloseNetWork")]
		extern static int  dx_CloseNetWork( int  NetHandle);
		public static int  CloseNetWork( int  NetHandle)
		{
			return dx_CloseNetWork( NetHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkAcceptState")]
		extern static int  dx_GetNetWorkAcceptState( int  NetHandle);
		public static int  GetNetWorkAcceptState( int  NetHandle)
		{
			return dx_GetNetWorkAcceptState( NetHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkDataLength")]
		extern static int  dx_GetNetWorkDataLength( int  NetHandle);
		public static int  GetNetWorkDataLength( int  NetHandle)
		{
			return dx_GetNetWorkDataLength( NetHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkSendDataLength")]
		extern static int  dx_GetNetWorkSendDataLength( int  NetHandle);
		public static int  GetNetWorkSendDataLength( int  NetHandle)
		{
			return dx_GetNetWorkSendDataLength( NetHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNewAcceptNetWork")]
		extern static int  dx_GetNewAcceptNetWork( );
		public static int  GetNewAcceptNetWork( )
		{
			return dx_GetNewAcceptNetWork( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLostNetWork")]
		extern static int  dx_GetLostNetWork( );
		public static int  GetLostNetWork( )
		{
			return dx_GetLostNetWork( );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkIP")]
		extern unsafe static int  dx_GetNetWorkIP( int  NetHandle, IPDATA *  IpBuf);
		public unsafe static int  GetNetWorkIP( int  NetHandle, IPDATA *  IpBuf)
		{
			return dx_GetNetWorkIP( NetHandle , IpBuf );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkIP_IPv6")]
		extern unsafe static int  dx_GetNetWorkIP_IPv6( int  NetHandle, IPDATA_IPv6 *  IpBuf);
		public unsafe static int  GetNetWorkIP_IPv6( int  NetHandle, IPDATA_IPv6 *  IpBuf)
		{
			return dx_GetNetWorkIP_IPv6( NetHandle , IpBuf );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetMyIPAddress")]
		extern unsafe static int  dx_GetMyIPAddress( IPDATA *  IpBuf);
		public unsafe static int  GetMyIPAddress( IPDATA *  IpBuf)
		{
			return dx_GetMyIPAddress( IpBuf );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_SetConnectTimeOutWait")]
		extern static int  dx_SetConnectTimeOutWait( int  Time);
		public static int  SetConnectTimeOutWait( int  Time)
		{
			return dx_SetConnectTimeOutWait( Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDXNetWorkProtocol")]
		extern static int  dx_SetUseDXNetWorkProtocol( int  Flag);
		public static int  SetUseDXNetWorkProtocol( int  Flag)
		{
			return dx_SetUseDXNetWorkProtocol( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseDXNetWorkProtocol")]
		extern static int  dx_GetUseDXNetWorkProtocol( );
		public static int  GetUseDXNetWorkProtocol( )
		{
			return dx_GetUseDXNetWorkProtocol( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDXProtocol")]
		extern static int  dx_SetUseDXProtocol( int  Flag);
		public static int  SetUseDXProtocol( int  Flag)
		{
			return dx_SetUseDXProtocol( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseDXProtocol")]
		extern static int  dx_GetUseDXProtocol( );
		public static int  GetUseDXProtocol( )
		{
			return dx_GetUseDXProtocol( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNetWorkCloseAfterLostFlag")]
		extern static int  dx_SetNetWorkCloseAfterLostFlag( int  Flag);
		public static int  SetNetWorkCloseAfterLostFlag( int  Flag)
		{
			return dx_SetNetWorkCloseAfterLostFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkCloseAfterLostFlag")]
		extern static int  dx_GetNetWorkCloseAfterLostFlag( );
		public static int  GetNetWorkCloseAfterLostFlag( )
		{
			return dx_GetNetWorkCloseAfterLostFlag( );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecv")]
		extern unsafe static int  dx_NetWorkRecv( int  NetHandle, void *  Buffer, int  Length);
		public unsafe static int  NetWorkRecv( int  NetHandle, void *  Buffer, int  Length)
		{
			return dx_NetWorkRecv( NetHandle , Buffer , Length );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecvToPeek")]
		extern unsafe static int  dx_NetWorkRecvToPeek( int  NetHandle, void *  Buffer, int  Length);
		public unsafe static int  NetWorkRecvToPeek( int  NetHandle, void *  Buffer, int  Length)
		{
			return dx_NetWorkRecvToPeek( NetHandle , Buffer , Length );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecvBufferClear")]
		extern static int  dx_NetWorkRecvBufferClear( int  NetHandle);
		public static int  NetWorkRecvBufferClear( int  NetHandle)
		{
			return dx_NetWorkRecvBufferClear( NetHandle );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkSend")]
		extern unsafe static int  dx_NetWorkSend( int  NetHandle, void *  Buffer, int  Length);
		public unsafe static int  NetWorkSend( int  NetHandle, void *  Buffer, int  Length)
		{
			return dx_NetWorkSend( NetHandle , Buffer , Length );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_MakeUDPSocket")]
		extern static int  dx_MakeUDPSocket( int  RecvPort);
		public static int  MakeUDPSocket( )
		{
			return dx_MakeUDPSocket( -1 );
		}
		public static int  MakeUDPSocket( int  RecvPort)
		{
			return dx_MakeUDPSocket( RecvPort );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeUDPSocket_IPv6")]
		extern static int  dx_MakeUDPSocket_IPv6( int  RecvPort);
		public static int  MakeUDPSocket_IPv6( )
		{
			return dx_MakeUDPSocket_IPv6( -1 );
		}
		public static int  MakeUDPSocket_IPv6( int  RecvPort)
		{
			return dx_MakeUDPSocket_IPv6( RecvPort );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteUDPSocket")]
		extern static int  dx_DeleteUDPSocket( int  NetUDPHandle);
		public static int  DeleteUDPSocket( int  NetUDPHandle)
		{
			return dx_DeleteUDPSocket( NetUDPHandle );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkSendUDP")]
		extern unsafe static int  dx_NetWorkSendUDP( int  NetUDPHandle, IPDATA  SendIP, int  SendPort, void *  Buffer, int  Length);
		public unsafe static int  NetWorkSendUDP( int  NetUDPHandle, IPDATA  SendIP, int  SendPort, void *  Buffer, int  Length)
		{
			return dx_NetWorkSendUDP( NetUDPHandle , SendIP , SendPort , Buffer , Length );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkSendUDP_IPv6")]
		extern unsafe static int  dx_NetWorkSendUDP_IPv6( int  NetUDPHandle, IPDATA_IPv6  SendIP, int  SendPort, void *  Buffer, int  Length);
		public unsafe static int  NetWorkSendUDP_IPv6( int  NetUDPHandle, IPDATA_IPv6  SendIP, int  SendPort, void *  Buffer, int  Length)
		{
			return dx_NetWorkSendUDP_IPv6( NetUDPHandle , SendIP , SendPort , Buffer , Length );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecvUDP")]
		extern unsafe static int  dx_NetWorkRecvUDP( int  NetUDPHandle, IPDATA *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek);
		public unsafe static int  NetWorkRecvUDP( int  NetUDPHandle, IPDATA *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek)
		{
			return dx_NetWorkRecvUDP( NetUDPHandle , RecvIP , RecvPort , Buffer , Length , Peek );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecvUDP_IPv6")]
		extern unsafe static int  dx_NetWorkRecvUDP_IPv6( int  NetUDPHandle, IPDATA_IPv6 *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek);
		public unsafe static int  NetWorkRecvUDP_IPv6( int  NetUDPHandle, IPDATA_IPv6 *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek)
		{
			return dx_NetWorkRecvUDP_IPv6( NetUDPHandle , RecvIP , RecvPort , Buffer , Length , Peek );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_CheckNetWorkRecvUDP")]
		extern static int  dx_CheckNetWorkRecvUDP( int  NetUDPHandle);
		public static int  CheckNetWorkRecvUDP( int  NetUDPHandle)
		{
			return dx_CheckNetWorkRecvUDP( NetUDPHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StockInputChar")]
		extern static int  dx_StockInputChar( char  CharCode);
		public static int  StockInputChar( char  CharCode)
		{
			return dx_StockInputChar( CharCode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClearInputCharBuf")]
		extern static int  dx_ClearInputCharBuf( );
		public static int  ClearInputCharBuf( )
		{
			return dx_ClearInputCharBuf( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetOneChar")]
		extern static int  dx_GetOneChar( System.Text.StringBuilder  CharBuffer, int  DeleteFlag);
		public static int  GetOneChar( System.Text.StringBuilder  CharBuffer, int  DeleteFlag)
		{
			return dx_GetOneChar( CharBuffer , DeleteFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetOneCharWait")]
		extern static int  dx_GetOneCharWait( System.Text.StringBuilder  CharBuffer, int  DeleteFlag);
		public static int  GetOneCharWait( System.Text.StringBuilder  CharBuffer, int  DeleteFlag)
		{
			return dx_GetOneCharWait( CharBuffer , DeleteFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCtrlCodeCmp")]
		extern static int  dx_GetCtrlCodeCmp( char  Char);
		public static int  GetCtrlCodeCmp( char  Char)
		{
			return dx_GetCtrlCodeCmp( Char );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawIMEInputString")]
		extern static int  dx_DrawIMEInputString( int  x, int  y, int  SelectStringNum);
		public static int  DrawIMEInputString( int  x, int  y, int  SelectStringNum)
		{
			return dx_DrawIMEInputString( x , y , SelectStringNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseIMEFlag")]
		extern static int  dx_SetUseIMEFlag( int  UseFlag);
		public static int  SetUseIMEFlag( int  UseFlag)
		{
			return dx_SetUseIMEFlag( UseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetInputStringMaxLengthIMESync")]
		extern static int  dx_SetInputStringMaxLengthIMESync( int  Flag);
		public static int  SetInputStringMaxLengthIMESync( int  Flag)
		{
			return dx_SetInputStringMaxLengthIMESync( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetIMEInputStringMaxLength")]
		extern static int  dx_SetIMEInputStringMaxLength( int  Length);
		public static int  SetIMEInputStringMaxLength( int  Length)
		{
			return dx_SetIMEInputStringMaxLength( Length );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStringPoint")]
		extern static int  dx_GetStringPoint( string  String, int  Point);
		public static int  GetStringPoint( string  String, int  Point)
		{
			return dx_GetStringPoint( String , Point );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStringPoint2")]
		extern static int  dx_GetStringPoint2( string  String, int  Point);
		public static int  GetStringPoint2( string  String, int  Point)
		{
			return dx_GetStringPoint2( String , Point );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawObtainsString")]
		extern static int  dx_DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor, int  SelectStrEdgeColor, int  SelectStart, int  SelectEnd);
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor)
		{
			return dx_DrawObtainsString( x , y , AddY , String , StrColor , 0 , -1 , -1 , 0 , -1 , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor)
		{
			return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , -1 , -1 , 0 , -1 , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle)
		{
			return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , -1 , 0 , -1 , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor)
		{
			return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , 0 , -1 , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor)
		{
			return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , -1 , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor, int  SelectStrEdgeColor)
		{
			return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor, int  SelectStrEdgeColor, int  SelectStart)
		{
			return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor, int  SelectStrEdgeColor, int  SelectStart, int  SelectEnd)
		{
			return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , SelectEnd );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawObtainsBox")]
		extern static int  dx_DrawObtainsBox( int  x1, int  y1, int  x2, int  y2, int  AddY, int  Color, int  FillFlag);
		public static int  DrawObtainsBox( int  x1, int  y1, int  x2, int  y2, int  AddY, int  Color, int  FillFlag)
		{
			return dx_DrawObtainsBox( x1 , y1 , x2 , y2 , AddY , Color , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InputStringToCustom")]
		extern static int  dx_InputStringToCustom( int  x, int  y, int  BufLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag);
		public static int  InputStringToCustom( int  x, int  y, int  BufLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag)
		{
			return dx_InputStringToCustom( x , y , BufLength , StrBuffer , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_KeyInputString")]
		extern static int  dx_KeyInputString( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag);
		public static int  KeyInputString( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag)
		{
			return dx_KeyInputString( x , y , CharMaxLength , StrBuffer , CancelValidFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_KeyInputSingleCharString")]
		extern static int  dx_KeyInputSingleCharString( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag);
		public static int  KeyInputSingleCharString( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag)
		{
			return dx_KeyInputSingleCharString( x , y , CharMaxLength , StrBuffer , CancelValidFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_KeyInputNumber")]
		extern static int  dx_KeyInputNumber( int  x, int  y, int  MaxNum, int  MinNum, int  CancelValidFlag);
		public static int  KeyInputNumber( int  x, int  y, int  MaxNum, int  MinNum, int  CancelValidFlag)
		{
			return dx_KeyInputNumber( x , y , MaxNum , MinNum , CancelValidFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetIMEInputModeStr")]
		extern static int  dx_GetIMEInputModeStr( System.Text.StringBuilder  GetBuffer);
		public static int  GetIMEInputModeStr( System.Text.StringBuilder  GetBuffer)
		{
			return dx_GetIMEInputModeStr( GetBuffer );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputStringFont")]
		extern static int  dx_SetKeyInputStringFont( int  FontHandle);
		public static int  SetKeyInputStringFont( int  FontHandle)
		{
			return dx_SetKeyInputStringFont( FontHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawKeyInputModeString")]
		extern static int  dx_DrawKeyInputModeString( int  x, int  y);
		public static int  DrawKeyInputModeString( int  x, int  y)
		{
			return dx_DrawKeyInputModeString( x , y );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitKeyInput")]
		extern static int  dx_InitKeyInput( );
		public static int  InitKeyInput( )
		{
			return dx_InitKeyInput( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeKeyInput")]
		extern static int  dx_MakeKeyInput( int  MaxStrLength, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag);
		public static int  MakeKeyInput( int  MaxStrLength, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag)
		{
			return dx_MakeKeyInput( MaxStrLength , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteKeyInput")]
		extern static int  dx_DeleteKeyInput( int  InputHandle);
		public static int  DeleteKeyInput( int  InputHandle)
		{
			return dx_DeleteKeyInput( InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetActiveKeyInput")]
		extern static int  dx_SetActiveKeyInput( int  InputHandle);
		public static int  SetActiveKeyInput( int  InputHandle)
		{
			return dx_SetActiveKeyInput( InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetActiveKeyInput")]
		extern static int  dx_GetActiveKeyInput( );
		public static int  GetActiveKeyInput( )
		{
			return dx_GetActiveKeyInput( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckKeyInput")]
		extern static int  dx_CheckKeyInput( int  InputHandle);
		public static int  CheckKeyInput( int  InputHandle)
		{
			return dx_CheckKeyInput( InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReStartKeyInput")]
		extern static int  dx_ReStartKeyInput( int  InputHandle);
		public static int  ReStartKeyInput( int  InputHandle)
		{
			return dx_ReStartKeyInput( InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessActKeyInput")]
		extern static int  dx_ProcessActKeyInput( );
		public static int  ProcessActKeyInput( )
		{
			return dx_ProcessActKeyInput( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawKeyInputString")]
		extern static int  dx_DrawKeyInputString( int  x, int  y, int  InputHandle);
		public static int  DrawKeyInputString( int  x, int  y, int  InputHandle)
		{
			return dx_DrawKeyInputString( x , y , InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputSelectArea")]
		extern static int  dx_SetKeyInputSelectArea( int  SelectStart, int  SelectEnd, int  InputHandle);
		public static int  SetKeyInputSelectArea( int  SelectStart, int  SelectEnd, int  InputHandle)
		{
			return dx_SetKeyInputSelectArea( SelectStart , SelectEnd , InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputSelectArea")]
		extern static int  dx_GetKeyInputSelectArea( out int  SelectStart, out int  SelectEnd, int  InputHandle);
		public static int  GetKeyInputSelectArea( out int  SelectStart, out int  SelectEnd, int  InputHandle)
		{
			return dx_GetKeyInputSelectArea( out SelectStart , out SelectEnd , InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputDrawStartPos")]
		extern static int  dx_SetKeyInputDrawStartPos( int  DrawStartPos, int  InputHandle);
		public static int  SetKeyInputDrawStartPos( int  DrawStartPos, int  InputHandle)
		{
			return dx_SetKeyInputDrawStartPos( DrawStartPos , InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputDrawStartPos")]
		extern static int  dx_GetKeyInputDrawStartPos( int  InputHandle);
		public static int  GetKeyInputDrawStartPos( int  InputHandle)
		{
			return dx_GetKeyInputDrawStartPos( InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputCursorBrinkTime")]
		extern static int  dx_SetKeyInputCursorBrinkTime( int  Time);
		public static int  SetKeyInputCursorBrinkTime( int  Time)
		{
			return dx_SetKeyInputCursorBrinkTime( Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputCursorBrinkFlag")]
		extern static int  dx_SetKeyInputCursorBrinkFlag( int  Flag);
		public static int  SetKeyInputCursorBrinkFlag( int  Flag)
		{
			return dx_SetKeyInputCursorBrinkFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputString")]
		extern static int  dx_SetKeyInputString( string  String, int  InputHandle);
		public static int  SetKeyInputString( string  String, int  InputHandle)
		{
			return dx_SetKeyInputString( String , InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputNumber")]
		extern static int  dx_SetKeyInputNumber( int  Number, int  InputHandle);
		public static int  SetKeyInputNumber( int  Number, int  InputHandle)
		{
			return dx_SetKeyInputNumber( Number , InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputNumberToFloat")]
		extern static int  dx_SetKeyInputNumberToFloat( float  Number, int  InputHandle);
		public static int  SetKeyInputNumberToFloat( float  Number, int  InputHandle)
		{
			return dx_SetKeyInputNumberToFloat( Number , InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputString")]
		extern static int  dx_GetKeyInputString( System.Text.StringBuilder  StrBuffer, int  InputHandle);
		public static int  GetKeyInputString( System.Text.StringBuilder  StrBuffer, int  InputHandle)
		{
			return dx_GetKeyInputString( StrBuffer , InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputNumber")]
		extern static int  dx_GetKeyInputNumber( int  InputHandle);
		public static int  GetKeyInputNumber( int  InputHandle)
		{
			return dx_GetKeyInputNumber( InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputNumberToFloat")]
		extern static float  dx_GetKeyInputNumberToFloat( int  InputHandle);
		public static float  GetKeyInputNumberToFloat( int  InputHandle)
		{
			return dx_GetKeyInputNumberToFloat( InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputCursorPosition")]
		extern static int  dx_SetKeyInputCursorPosition( int  Position, int  InputHandle);
		public static int  SetKeyInputCursorPosition( int  Position, int  InputHandle)
		{
			return dx_SetKeyInputCursorPosition( Position , InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputCursorPosition")]
		extern static int  dx_GetKeyInputCursorPosition( int  InputHandle);
		public static int  GetKeyInputCursorPosition( int  InputHandle)
		{
			return dx_GetKeyInputCursorPosition( InputHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckHitKey")]
		extern static int  dx_CheckHitKey( int  KeyCode);
		public static int  CheckHitKey( int  KeyCode)
		{
			return dx_CheckHitKey( KeyCode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckHitKeyAll")]
		extern static int  dx_CheckHitKeyAll( int  CheckType);
		public static int  CheckHitKeyAll( )
		{
			return dx_CheckHitKeyAll( DX_CHECKINPUT_ALL );
		}
		public static int  CheckHitKeyAll( int  CheckType)
		{
			return dx_CheckHitKeyAll( CheckType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetHitKeyStateAll")]
		extern static int  dx_GetHitKeyStateAll( out byte  KeyStateBuf);
		public static int  GetHitKeyStateAll( out byte  KeyStateBuf)
		{
			return dx_GetHitKeyStateAll( out KeyStateBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyExclusiveCooperativeLevelFlag")]
		extern static int  dx_SetKeyExclusiveCooperativeLevelFlag( int  Flag);
		public static int  SetKeyExclusiveCooperativeLevelFlag( int  Flag)
		{
			return dx_SetKeyExclusiveCooperativeLevelFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadNum")]
		extern static int  dx_GetJoypadNum( );
		public static int  GetJoypadNum( )
		{
			return dx_GetJoypadNum( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadInputState")]
		extern static int  dx_GetJoypadInputState( int  InputType);
		public static int  GetJoypadInputState( int  InputType)
		{
			return dx_GetJoypadInputState( InputType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadAnalogInput")]
		extern static int  dx_GetJoypadAnalogInput( out int  XBuf, out int  YBuf, int  InputType);
		public static int  GetJoypadAnalogInput( out int  XBuf, out int  YBuf, int  InputType)
		{
			return dx_GetJoypadAnalogInput( out XBuf , out YBuf , InputType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadAnalogInputRight")]
		extern static int  dx_GetJoypadAnalogInputRight( out int  XBuf, out int  YBuf, int  InputType);
		public static int  GetJoypadAnalogInputRight( out int  XBuf, out int  YBuf, int  InputType)
		{
			return dx_GetJoypadAnalogInputRight( out XBuf , out YBuf , InputType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadDirectInputState")]
		extern static int  dx_GetJoypadDirectInputState( int  InputType, out DINPUT_JOYSTATE  DInputState);
		public static int  GetJoypadDirectInputState( int  InputType, out DINPUT_JOYSTATE  DInputState)
		{
			return dx_GetJoypadDirectInputState( InputType , out DInputState );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_KeyboradBufferProcess")]
		extern static int  dx_KeyboradBufferProcess( );
		public static int  KeyboradBufferProcess( )
		{
			return dx_KeyboradBufferProcess( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvertKeyCodeToVirtualKey")]
		extern static int  dx_ConvertKeyCodeToVirtualKey( int  KeyCode);
		public static int  ConvertKeyCodeToVirtualKey( int  KeyCode)
		{
			return dx_ConvertKeyCodeToVirtualKey( KeyCode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetJoypadInputToKeyInput")]
		extern static int  dx_SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3, int  KeyInput4);
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1)
		{
			return dx_SetJoypadInputToKeyInput( InputType , PadInput , KeyInput1 , -1 , -1 , -1 );
		}
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2)
		{
			return dx_SetJoypadInputToKeyInput( InputType , PadInput , KeyInput1 , KeyInput2 , -1 , -1 );
		}
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3)
		{
			return dx_SetJoypadInputToKeyInput( InputType , PadInput , KeyInput1 , KeyInput2 , KeyInput3 , -1 );
		}
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3, int  KeyInput4)
		{
			return dx_SetJoypadInputToKeyInput( InputType , PadInput , KeyInput1 , KeyInput2 , KeyInput3 , KeyInput4 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetJoypadDeadZone")]
		extern static int  dx_SetJoypadDeadZone( int  InputType, double  Zone);
		public static int  SetJoypadDeadZone( int  InputType, double  Zone)
		{
			return dx_SetJoypadDeadZone( InputType , Zone );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StartJoypadVibration")]
		extern static int  dx_StartJoypadVibration( int  InputType, int  Power, int  Time);
		public static int  StartJoypadVibration( int  InputType, int  Power, int  Time)
		{
			return dx_StartJoypadVibration( InputType , Power , Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopJoypadVibration")]
		extern static int  dx_StopJoypadVibration( int  InputType);
		public static int  StopJoypadVibration( int  InputType)
		{
			return dx_StopJoypadVibration( InputType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadPOVState")]
		extern static int  dx_GetJoypadPOVState( int  InputType, int  POVNumber);
		public static int  GetJoypadPOVState( int  InputType, int  POVNumber)
		{
			return dx_GetJoypadPOVState( InputType , POVNumber );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadName")]
		extern static int  dx_GetJoypadName( int  InputType, System.Text.StringBuilder  InstanceNameBuffer, System.Text.StringBuilder  ProductNameBuffer);
		public static int  GetJoypadName( int  InputType, System.Text.StringBuilder  InstanceNameBuffer, System.Text.StringBuilder  ProductNameBuffer)
		{
			return dx_GetJoypadName( InputType , InstanceNameBuffer , ProductNameBuffer );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReSetupJoypad")]
		extern static int  dx_ReSetupJoypad( );
		public static int  ReSetupJoypad( )
		{
			return dx_ReSetupJoypad( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyboardNotDirectInputFlag")]
		extern static int  dx_SetKeyboardNotDirectInputFlag( int  Flag);
		public static int  SetKeyboardNotDirectInputFlag( int  Flag)
		{
			return dx_SetKeyboardNotDirectInputFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDirectInputFlag")]
		extern static int  dx_SetUseDirectInputFlag( int  Flag);
		public static int  SetUseDirectInputFlag( int  Flag)
		{
			return dx_SetUseDirectInputFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseJoypadVibrationFlag")]
		extern static int  dx_SetUseJoypadVibrationFlag( int  Flag);
		public static int  SetUseJoypadVibrationFlag( int  Flag)
		{
			return dx_SetUseJoypadVibrationFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set2D3DKyouzonFlag")]
		extern static int  dx_Set2D3DKyouzonFlag( int  Flag);
		public static int  Set2D3DKyouzonFlag( int  Flag)
		{
			return dx_Set2D3DKyouzonFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotUse3DFlag")]
		extern static int  dx_SetNotUse3DFlag( int  Flag);
		public static int  SetNotUse3DFlag( int  Flag)
		{
			return dx_SetNotUse3DFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBasicBlendFlag")]
		extern static int  dx_SetBasicBlendFlag( int  Flag);
		public static int  SetBasicBlendFlag( int  Flag)
		{
			return dx_SetBasicBlendFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetScreenMemToVramFlag")]
		extern static int  dx_SetScreenMemToVramFlag( int  Flag);
		public static int  SetScreenMemToVramFlag( int  Flag)
		{
			return dx_SetScreenMemToVramFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseSoftwareRenderModeFlag")]
		extern static int  dx_SetUseSoftwareRenderModeFlag( int  Flag);
		public static int  SetUseSoftwareRenderModeFlag( int  Flag)
		{
			return dx_SetUseSoftwareRenderModeFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDirectDrawFlag")]
		extern static int  dx_SetUseDirectDrawFlag( int  Flag);
		public static int  SetUseDirectDrawFlag( int  Flag)
		{
			return dx_SetUseDirectDrawFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseGDIFlag")]
		extern static int  dx_SetUseGDIFlag( int  Flag);
		public static int  SetUseGDIFlag( int  Flag)
		{
			return dx_SetUseGDIFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDisplayRefreshRate")]
		extern static int  dx_SetDisplayRefreshRate( int  RefreshRate);
		public static int  SetDisplayRefreshRate( int  RefreshRate)
		{
			return dx_SetDisplayRefreshRate( RefreshRate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMultiThreadFlag")]
		extern static int  dx_SetMultiThreadFlag( int  Flag);
		public static int  SetMultiThreadFlag( int  Flag)
		{
			return dx_SetMultiThreadFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDirectDrawDeviceIndex")]
		extern static int  dx_SetUseDirectDrawDeviceIndex( int  Index);
		public static int  SetUseDirectDrawDeviceIndex( int  Index)
		{
			return dx_SetUseDirectDrawDeviceIndex( Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseTempFrontScreen")]
		extern static int  dx_SetUseTempFrontScreen( int  Flag);
		public static int  SetUseTempFrontScreen( int  Flag)
		{
			return dx_SetUseTempFrontScreen( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawScreenSize")]
		extern static int  dx_GetDrawScreenSize( out int  XBuf, out int  YBuf);
		public static int  GetDrawScreenSize( out int  XBuf, out int  YBuf)
		{
			return dx_GetDrawScreenSize( out XBuf , out YBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetScreenBitDepth")]
		extern static int  dx_GetScreenBitDepth( );
		public static int  GetScreenBitDepth( )
		{
			return dx_GetScreenBitDepth( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetBmpSurf3DRenderingValidState")]
		extern static int  dx_GetBmpSurf3DRenderingValidState( int  BmpIndex);
		public static int  GetBmpSurf3DRenderingValidState( int  BmpIndex)
		{
			return dx_GetBmpSurf3DRenderingValidState( BmpIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDesktopDrawCmp")]
		extern static int  dx_GetDesktopDrawCmp( );
		public static int  GetDesktopDrawCmp( )
		{
			return dx_GetDesktopDrawCmp( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseDirectDrawFlag")]
		extern static int  dx_GetUseDirectDrawFlag( );
		public static int  GetUseDirectDrawFlag( )
		{
			return dx_GetUseDirectDrawFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColorBitDepth")]
		extern static int  dx_GetColorBitDepth( );
		public static int  GetColorBitDepth( )
		{
			return dx_GetColorBitDepth( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetChangeDisplayFlag")]
		extern static int  dx_GetChangeDisplayFlag( );
		public static int  GetChangeDisplayFlag( )
		{
			return dx_GetChangeDisplayFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetScreenMemToSystemMemFlag")]
		extern static int  dx_GetScreenMemToSystemMemFlag( );
		public static int  GetScreenMemToSystemMemFlag( )
		{
			return dx_GetScreenMemToSystemMemFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetVideoMemorySize")]
		extern static int  dx_GetVideoMemorySize( out int  AllSize, out int  FreeSize);
		public static int  GetVideoMemorySize( out int  AllSize, out int  FreeSize)
		{
			return dx_GetVideoMemorySize( out AllSize , out FreeSize );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseGDIFlag")]
		extern static int  dx_GetUseGDIFlag( );
		public static int  GetUseGDIFlag( )
		{
			return dx_GetUseGDIFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNotDraw3DFlag")]
		extern static int  dx_GetNotDraw3DFlag( );
		public static int  GetNotDraw3DFlag( )
		{
			return dx_GetNotDraw3DFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDirectDrawDeviceDescription")]
		extern static int  dx_GetDirectDrawDeviceDescription( int  Number, System.Text.StringBuilder  StringBuffer);
		public static int  GetDirectDrawDeviceDescription( int  Number, System.Text.StringBuilder  StringBuffer)
		{
			return dx_GetDirectDrawDeviceDescription( Number , StringBuffer );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDirectDrawDeviceNum")]
		extern static int  dx_GetDirectDrawDeviceNum( );
		public static int  GetDirectDrawDeviceNum( )
		{
			return dx_GetDirectDrawDeviceNum( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseMEMIMGFlag")]
		extern static int  dx_GetUseMEMIMGFlag( );
		public static int  GetUseMEMIMGFlag( )
		{
			return dx_GetUseMEMIMGFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetVSyncTime")]
		extern static int  dx_GetVSyncTime( );
		public static int  GetVSyncTime( )
		{
			return dx_GetVSyncTime( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetRefreshRate")]
		extern static int  dx_GetRefreshRate( );
		public static int  GetRefreshRate( )
		{
			return dx_GetRefreshRate( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDisplayModeNum")]
		extern static int  dx_GetDisplayModeNum( );
		public static int  GetDisplayModeNum( )
		{
			return dx_GetDisplayModeNum( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDisplayMode")]
		extern static DISPLAYMODEDATA  dx_GetDisplayMode( int  ModeIndex);
		public static DISPLAYMODEDATA  GetDisplayMode( int  ModeIndex)
		{
			return dx_GetDisplayMode( ModeIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPalette")]
		extern static int  dx_SetPalette( int  PalIndex, int  Red, int  Green, int  Blue);
		public static int  SetPalette( int  PalIndex, int  Red, int  Green, int  Blue)
		{
			return dx_SetPalette( PalIndex , Red , Green , Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReflectionPalette")]
		extern static int  dx_ReflectionPalette( );
		public static int  ReflectionPalette( )
		{
			return dx_ReflectionPalette( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPalette")]
		extern static int  dx_GetPalette( int  PalIndex, out int  Red, out int  Green, out int  Blue);
		public static int  GetPalette( int  PalIndex, out int  Red, out int  Green, out int  Blue)
		{
			return dx_GetPalette( PalIndex , out Red , out Green , out Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBmpPal")]
		extern static int  dx_SetBmpPal( string  FileName);
		public static int  SetBmpPal( string  FileName)
		{
			return dx_SetBmpPal( FileName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBmpPalPart")]
		extern static int  dx_SetBmpPalPart( string  FileName, int  StartNum, int  GetNum, int  SetNum);
		public static int  SetBmpPalPart( string  FileName, int  StartNum, int  GetNum, int  SetNum)
		{
			return dx_SetBmpPalPart( FileName , StartNum , GetNum , SetNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphPalette")]
		extern static int  dx_GetGraphPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue);
		public static int  GetGraphPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue)
		{
			return dx_GetGraphPalette( GrHandle , ColorIndex , out Red , out Green , out Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphOriginalPalette")]
		extern static int  dx_GetGraphOriginalPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue);
		public static int  GetGraphOriginalPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue)
		{
			return dx_GetGraphOriginalPalette( GrHandle , ColorIndex , out Red , out Green , out Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphPalette")]
		extern static int  dx_SetGraphPalette( int  GrHandle, int  ColorIndex, int  Color);
		public static int  SetGraphPalette( int  GrHandle, int  ColorIndex, int  Color)
		{
			return dx_SetGraphPalette( GrHandle , ColorIndex , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetGraphPalette")]
		extern static int  dx_ResetGraphPalette( int  GrHandle);
		public static int  ResetGraphPalette( int  GrHandle)
		{
			return dx_ResetGraphPalette( GrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixel")]
		extern static int  dx_GetPixel( int  x, int  y);
		public static int  GetPixel( int  x, int  y)
		{
			return dx_GetPixel( x , y );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Paint")]
		extern static int  dx_Paint( int  x, int  y, int  FillColor, int  BoundaryColor);
		public static int  Paint( int  x, int  y, int  FillColor)
		{
			return dx_Paint( x , y , FillColor , -1 );
		}
		public static int  Paint( int  x, int  y, int  FillColor, int  BoundaryColor)
		{
			return dx_Paint( x , y , FillColor , BoundaryColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_WaitVSync")]
		extern static int  dx_WaitVSync( int  SyncNum);
		public static int  WaitVSync( int  SyncNum)
		{
			return dx_WaitVSync( SyncNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ScreenFlip")]
		extern static int  dx_ScreenFlip( );
		public static int  ScreenFlip( )
		{
			return dx_ScreenFlip( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ScreenCopy")]
		extern static int  dx_ScreenCopy( );
		public static int  ScreenCopy( )
		{
			return dx_ScreenCopy( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltBackScreenToWindow")]
		extern static int  dx_BltBackScreenToWindow( System.IntPtr  Window, int  ClientX, int  ClientY);
		public static int  BltBackScreenToWindow( System.IntPtr  Window, int  ClientX, int  ClientY)
		{
			return dx_BltBackScreenToWindow( Window , ClientX , ClientY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltRectBackScreenToWindow")]
		extern static int  dx_BltRectBackScreenToWindow( System.IntPtr  Window, RECT  BackScreenRect, RECT  WindowClientRect);
		public static int  BltRectBackScreenToWindow( System.IntPtr  Window, RECT  BackScreenRect, RECT  WindowClientRect)
		{
			return dx_BltRectBackScreenToWindow( Window , BackScreenRect , WindowClientRect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GraphCopy")]
		extern static int  dx_GraphCopy( out RECT  SrcRect, out RECT  DestRect, int  SrcHandle, int  DestHandle);
		public static int  GraphCopy( out RECT  SrcRect, out RECT  DestRect, int  SrcHandle)
		{
			return dx_GraphCopy( out SrcRect , out DestRect , SrcHandle , DX_SCREEN_BACK );
		}
		public static int  GraphCopy( out RECT  SrcRect, out RECT  DestRect, int  SrcHandle, int  DestHandle)
		{
			return dx_GraphCopy( out SrcRect , out DestRect , SrcHandle , DestHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphMode")]
		extern static int  dx_SetGraphMode( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth, int  RefreshRate);
		public static int  SetGraphMode( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth)
		{
			return dx_SetGraphMode( ScreenSizeX , ScreenSizeY , ColorBitDepth , 60 );
		}
		public static int  SetGraphMode( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth, int  RefreshRate)
		{
			return dx_SetGraphMode( ScreenSizeX , ScreenSizeY , ColorBitDepth , RefreshRate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBufferSize")]
		extern static int  dx_SetZBufferSize( int  ZBufferSizeX, int  ZBufferSizeY);
		public static int  SetZBufferSize( int  ZBufferSizeX, int  ZBufferSizeY)
		{
			return dx_SetZBufferSize( ZBufferSizeX , ZBufferSizeY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFullSceneAntiAliasingMode")]
		extern static int  dx_SetFullSceneAntiAliasingMode( int  Samples, int  Quality);
		public static int  SetFullSceneAntiAliasingMode( int  Samples, int  Quality)
		{
			return dx_SetFullSceneAntiAliasingMode( Samples , Quality );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphDisplayArea")]
		extern static int  dx_SetGraphDisplayArea( int  x1, int  y1, int  x2, int  y2);
		public static int  SetGraphDisplayArea( int  x1, int  y1, int  x2, int  y2)
		{
			return dx_SetGraphDisplayArea( x1 , y1 , x2 , y2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetChangeScreenModeGraphicsSystemResetFlag")]
		extern static int  dx_SetChangeScreenModeGraphicsSystemResetFlag( int  Flag);
		public static int  SetChangeScreenModeGraphicsSystemResetFlag( int  Flag)
		{
			return dx_SetChangeScreenModeGraphicsSystemResetFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveDrawScreen")]
		extern static int  dx_SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel);
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
			return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , DX_IMAGESAVETYPE_BMP , 80 , TRUE , -1 );
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType)
		{
			return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , SaveType , 80 , TRUE , -1 );
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality)
		{
			return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , TRUE , -1 );
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1)
		{
			return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , -1 );
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel)
		{
			return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , Png_CompressionLevel );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveDrawScreenToBMP")]
		extern static int  dx_SaveDrawScreenToBMP( int  x1, int  y1, int  x2, int  y2, string  FileName);
		public static int  SaveDrawScreenToBMP( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
			return dx_SaveDrawScreenToBMP( x1 , y1 , x2 , y2 , FileName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveDrawScreenToJPEG")]
		extern static int  dx_SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality, int  Sample2x1);
		public static int  SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
			return dx_SaveDrawScreenToJPEG( x1 , y1 , x2 , y2 , FileName , 80 , TRUE );
		}
		public static int  SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality)
		{
			return dx_SaveDrawScreenToJPEG( x1 , y1 , x2 , y2 , FileName , Quality , TRUE );
		}
		public static int  SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality, int  Sample2x1)
		{
			return dx_SaveDrawScreenToJPEG( x1 , y1 , x2 , y2 , FileName , Quality , Sample2x1 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveDrawScreenToPNG")]
		extern static int  dx_SaveDrawScreenToPNG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  CompressionLevel);
		public static int  SaveDrawScreenToPNG( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
			return dx_SaveDrawScreenToPNG( x1 , y1 , x2 , y2 , FileName , -1 );
		}
		public static int  SaveDrawScreenToPNG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  CompressionLevel)
		{
			return dx_SaveDrawScreenToPNG( x1 , y1 , x2 , y2 , FileName , CompressionLevel );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDivGraphFlag")]
		extern static int  dx_SetUseDivGraphFlag( int  Flag);
		public static int  SetUseDivGraphFlag( int  Flag)
		{
			return dx_SetUseDivGraphFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseMaxTextureSize")]
		extern static int  dx_SetUseMaxTextureSize( int  Size);
		public static int  SetUseMaxTextureSize( int  Size)
		{
			return dx_SetUseMaxTextureSize( Size );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseVertexBufferFlag")]
		extern static int  dx_SetUseVertexBufferFlag( int  Flag);
		public static int  SetUseVertexBufferFlag( int  Flag)
		{
			return dx_SetUseVertexBufferFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseOldDrawModiGraphCodeFlag")]
		extern static int  dx_SetUseOldDrawModiGraphCodeFlag( int  Flag);
		public static int  SetUseOldDrawModiGraphCodeFlag( int  Flag)
		{
			return dx_SetUseOldDrawModiGraphCodeFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeGraph")]
		extern static int  dx_MakeGraph( int  SizeX, int  SizeY, int  NotUse3DFlag);
		public static int  MakeGraph( int  SizeX, int  SizeY)
		{
			return dx_MakeGraph( SizeX , SizeY , FALSE );
		}
		public static int  MakeGraph( int  SizeX, int  SizeY, int  NotUse3DFlag)
		{
			return dx_MakeGraph( SizeX , SizeY , NotUse3DFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeScreen")]
		extern static int  dx_MakeScreen( int  SizeX, int  SizeY, int  UseAlphaChannel);
		public static int  MakeScreen( int  SizeX, int  SizeY)
		{
			return dx_MakeScreen( SizeX , SizeY , FALSE );
		}
		public static int  MakeScreen( int  SizeX, int  SizeY, int  UseAlphaChannel)
		{
			return dx_MakeScreen( SizeX , SizeY , UseAlphaChannel );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteGraph")]
		extern static int  dx_DeleteGraph( int  GrHandle, int  LogOutFlag);
		public static int  DeleteGraph( int  GrHandle)
		{
			return dx_DeleteGraph( GrHandle , FALSE );
		}
		public static int  DeleteGraph( int  GrHandle, int  LogOutFlag)
		{
			return dx_DeleteGraph( GrHandle , LogOutFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSharingGraph")]
		extern static int  dx_DeleteSharingGraph( int  GrHandle);
		public static int  DeleteSharingGraph( int  GrHandle)
		{
			return dx_DeleteSharingGraph( GrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphNum")]
		extern static int  dx_GetGraphNum( );
		public static int  GetGraphNum( )
		{
			return dx_GetGraphNum( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphLostFlag")]
		extern static int  dx_SetGraphLostFlag( int  GrHandle, out int  LostFlag);
		public static int  SetGraphLostFlag( int  GrHandle, out int  LostFlag)
		{
			return dx_SetGraphLostFlag( GrHandle , out LostFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitGraph")]
		extern static int  dx_InitGraph( int  LogOutFlag);
		public static int  InitGraph( )
		{
			return dx_InitGraph( FALSE );
		}
		public static int  InitGraph( int  LogOutFlag)
		{
			return dx_InitGraph( LogOutFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_OpenMovieToOverlay")]
		extern static int  dx_OpenMovieToOverlay( string  FileName);
		public static int  OpenMovieToOverlay( string  FileName)
		{
			return dx_OpenMovieToOverlay( FileName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_UpdateMovieToOverlay")]
		extern static int  dx_UpdateMovieToOverlay( int  x, int  y, int  ExRate, int  ShowFlag, int  MovieHandle);
		public static int  UpdateMovieToOverlay( int  x, int  y, int  ExRate, int  ShowFlag, int  MovieHandle)
		{
			return dx_UpdateMovieToOverlay( x , y , ExRate , ShowFlag , MovieHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CloseMovieToOverlay")]
		extern static int  dx_CloseMovieToOverlay( int  MovieHandle);
		public static int  CloseMovieToOverlay( int  MovieHandle)
		{
			return dx_CloseMovieToOverlay( MovieHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadFileGraphAll")]
		extern static int  dx_ReloadFileGraphAll( );
		public static int  ReloadFileGraphAll( )
		{
			return dx_ReloadFileGraphAll( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphTransColor")]
		extern static int  dx_SetGraphTransColor( int  GrHandle, int  Red, int  Green, int  Blue);
		public static int  SetGraphTransColor( int  GrHandle, int  Red, int  Green, int  Blue)
		{
			return dx_SetGraphTransColor( GrHandle , Red , Green , Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RestoreGraph")]
		extern static int  dx_RestoreGraph( int  GrHandle);
		public static int  RestoreGraph( int  GrHandle)
		{
			return dx_RestoreGraph( GrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AllRestoreGraph")]
		extern static int  dx_AllRestoreGraph( );
		public static int  AllRestoreGraph( )
		{
			return dx_AllRestoreGraph( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClsDrawScreen")]
		extern static int  dx_ClsDrawScreen( );
		public static int  ClsDrawScreen( )
		{
			return dx_ClsDrawScreen( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadGraphScreen")]
		extern static int  dx_LoadGraphScreen( int  x, int  y, string  GraphName, int  TransFlag);
		public static int  LoadGraphScreen( int  x, int  y, string  GraphName, int  TransFlag)
		{
			return dx_LoadGraphScreen( x , y , GraphName , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawGraph")]
		extern static int  dx_DrawGraph( int  x, int  y, int  GrHandle, int  TransFlag);
		public static int  DrawGraph( int  x, int  y, int  GrHandle, int  TransFlag)
		{
			return dx_DrawGraph( x , y , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawGraphF")]
		extern static int  dx_DrawGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag);
		public static int  DrawGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag)
		{
			return dx_DrawGraphF( xf , yf , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendGraph")]
		extern static int  dx_DrawExtendGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  TransFlag);
		public static int  DrawExtendGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  TransFlag)
		{
			return dx_DrawExtendGraph( x1 , y1 , x2 , y2 , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendGraphF")]
		extern static int  dx_DrawExtendGraphF( float  x1f, float  y1f, float  x2f, float  y2, int  GrHandle, int  TransFlag);
		public static int  DrawExtendGraphF( float  x1f, float  y1f, float  x2f, float  y2, int  GrHandle, int  TransFlag)
		{
			return dx_DrawExtendGraphF( x1f , y1f , x2f , y2 , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph")]
		extern static int  dx_DrawRotaGraph( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawRotaGraph( x , y , ExRate , Angle , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawRotaGraph( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRotaGraph( x , y , ExRate , Angle , GrHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraphF")]
		extern static int  dx_DrawRotaGraphF( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraphF( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawRotaGraphF( xf , yf , ExRate , Angle , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawRotaGraphF( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRotaGraphF( xf , yf , ExRate , Angle , GrHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph2")]
		extern static int  dx_DrawRotaGraph2( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph2( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawRotaGraph2( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawRotaGraph2( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRotaGraph2( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph2F")]
		extern static int  dx_DrawRotaGraph2F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph2F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawRotaGraph2F( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawRotaGraph2F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRotaGraph2F( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawModiGraph")]
		extern static int  dx_DrawModiGraph( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  TransFlag);
		public static int  DrawModiGraph( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  TransFlag)
		{
			return dx_DrawModiGraph( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawModiGraphF")]
		extern static int  dx_DrawModiGraphF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag);
		public static int  DrawModiGraphF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag)
		{
			return dx_DrawModiGraphF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTurnGraph")]
		extern static int  dx_DrawTurnGraph( int  x, int  y, int  GrHandle, int  TransFlag);
		public static int  DrawTurnGraph( int  x, int  y, int  GrHandle, int  TransFlag)
		{
			return dx_DrawTurnGraph( x , y , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTurnGraphF")]
		extern static int  dx_DrawTurnGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag);
		public static int  DrawTurnGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag)
		{
			return dx_DrawTurnGraphF( xf , yf , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTile")]
		extern static int  dx_DrawTile( int  x1, int  y1, int  x2, int  y2, int  Tx, int  Ty, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag);
		public static int  DrawTile( int  x1, int  y1, int  x2, int  y2, int  Tx, int  Ty, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawTile( x1 , y1 , x2 , y2 , Tx , Ty , ExtRate , Angle , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectGraph")]
		extern static int  dx_DrawRectGraph( int  DestX, int  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectGraph( int  DestX, int  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRectGraph( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectExtendGraph")]
		extern static int  dx_DrawRectExtendGraph( int  DestX1, int  DestY1, int  DestX2, int  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag);
		public static int  DrawRectExtendGraph( int  DestX1, int  DestY1, int  DestX2, int  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag)
		{
			return dx_DrawRectExtendGraph( DestX1 , DestY1 , DestX2 , DestY2 , SrcX , SrcY , SrcWidth , SrcHeight , GraphHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectRotaGraph")]
		extern static int  dx_DrawRectRotaGraph( int  X, int  Y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectRotaGraph( int  X, int  Y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRectRotaGraph( X , Y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectGraphF")]
		extern static int  dx_DrawRectGraphF( float  DestX, float  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectGraphF( float  DestX, float  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRectGraphF( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectExtendGraphF")]
		extern static int  dx_DrawRectExtendGraphF( float  DestX1, float  DestY1, float  DestX2, float  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag);
		public static int  DrawRectExtendGraphF( float  DestX1, float  DestY1, float  DestX2, float  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag)
		{
			return dx_DrawRectExtendGraphF( DestX1 , DestY1 , DestX2 , DestY2 , SrcX , SrcY , SrcWidth , SrcHeight , GraphHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectRotaGraphF")]
		extern static int  dx_DrawRectRotaGraphF( float  X, float  Y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectRotaGraphF( float  X, float  Y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRectRotaGraphF( X , Y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBlendGraph")]
		extern static int  dx_DrawBlendGraph( int  x, int  y, int  GrHandle, int  TransFlag, int  BlendGraph, int  BorderParam, int  BorderRange);
		public static int  DrawBlendGraph( int  x, int  y, int  GrHandle, int  TransFlag, int  BlendGraph, int  BorderParam, int  BorderRange)
		{
			return dx_DrawBlendGraph( x , y , GrHandle , TransFlag , BlendGraph , BorderParam , BorderRange );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBlendGraphPos")]
		extern static int  dx_DrawBlendGraphPos( int  x, int  y, int  GrHandle, int  TransFlag, int  bx, int  by, int  BlendGraph, int  BorderParam, int  BorderRange);
		public static int  DrawBlendGraphPos( int  x, int  y, int  GrHandle, int  TransFlag, int  bx, int  by, int  BlendGraph, int  BorderParam, int  BorderRange)
		{
			return dx_DrawBlendGraphPos( x , y , GrHandle , TransFlag , bx , by , BlendGraph , BorderParam , BorderRange );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCircleGauge")]
		extern static int  dx_DrawCircleGauge( int  CenterX, int  CenterY, double  Percent, int  GrHandle);
		public static int  DrawCircleGauge( int  CenterX, int  CenterY, double  Percent, int  GrHandle)
		{
			return dx_DrawCircleGauge( CenterX , CenterY , Percent , GrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawGraphToZBuffer")]
		extern static int  dx_DrawGraphToZBuffer( int  X, int  Y, int  GrHandle, int  WriteZMode);
		public static int  DrawGraphToZBuffer( int  X, int  Y, int  GrHandle, int  WriteZMode)
		{
			return dx_DrawGraphToZBuffer( X , Y , GrHandle , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTurnGraphToZBuffer")]
		extern static int  dx_DrawTurnGraphToZBuffer( int  x, int  y, int  GrHandle, int  WriteZMode);
		public static int  DrawTurnGraphToZBuffer( int  x, int  y, int  GrHandle, int  WriteZMode)
		{
			return dx_DrawTurnGraphToZBuffer( x , y , GrHandle , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendGraphToZBuffer")]
		extern static int  dx_DrawExtendGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  WriteZMode);
		public static int  DrawExtendGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  WriteZMode)
		{
			return dx_DrawExtendGraphToZBuffer( x1 , y1 , x2 , y2 , GrHandle , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraphToZBuffer")]
		extern static int  dx_DrawRotaGraphToZBuffer( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag);
		public static int  DrawRotaGraphToZBuffer( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode)
		{
			return dx_DrawRotaGraphToZBuffer( x , y , ExRate , Angle , GrHandle , WriteZMode , FALSE );
		}
		public static int  DrawRotaGraphToZBuffer( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag)
		{
			return dx_DrawRotaGraphToZBuffer( x , y , ExRate , Angle , GrHandle , WriteZMode , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawModiGraphToZBuffer")]
		extern static int  dx_DrawModiGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  WriteZMode);
		public static int  DrawModiGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  WriteZMode)
		{
			return dx_DrawModiGraphToZBuffer( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBoxToZBuffer")]
		extern static int  dx_DrawBoxToZBuffer( int  x1, int  y1, int  x2, int  y2, int  FillFlag, int  WriteZMode);
		public static int  DrawBoxToZBuffer( int  x1, int  y1, int  x2, int  y2, int  FillFlag, int  WriteZMode)
		{
			return dx_DrawBoxToZBuffer( x1 , y1 , x2 , y2 , FillFlag , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCircleToZBuffer")]
		extern static int  dx_DrawCircleToZBuffer( int  x, int  y, int  r, int  FillFlag, int  WriteZMode);
		public static int  DrawCircleToZBuffer( int  x, int  y, int  r, int  FillFlag, int  WriteZMode)
		{
			return dx_DrawCircleToZBuffer( x , y , r , FillFlag , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringToZBuffer")]
		extern static int  dx_DrawStringToZBuffer( int  x, int  y, string  String, int  WriteZMode);
		public static int  DrawStringToZBuffer( int  x, int  y, string  String, int  WriteZMode)
		{
			return dx_DrawStringToZBuffer( x , y , String , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawVStringToZBuffer")]
		extern static int  dx_DrawVStringToZBuffer( int  x, int  y, string  String, int  WriteZMode);
		public static int  DrawVStringToZBuffer( int  x, int  y, string  String, int  WriteZMode)
		{
			return dx_DrawVStringToZBuffer( x , y , String , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringToHandleToZBuffer")]
		extern static int  dx_DrawStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		public static int  DrawStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode)
		{
			return dx_DrawStringToHandleToZBuffer( x , y , String , FontHandle , WriteZMode , FALSE );
		}
		public static int  DrawStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag)
		{
			return dx_DrawStringToHandleToZBuffer( x , y , String , FontHandle , WriteZMode , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawVStringToHandleToZBuffer")]
		extern static int  dx_DrawVStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode);
		public static int  DrawVStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode)
		{
			return dx_DrawVStringToHandleToZBuffer( x , y , String , FontHandle , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendStringToZBuffer")]
		extern static int  dx_DrawExtendStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode);
		public static int  DrawExtendStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode)
		{
			return dx_DrawExtendStringToZBuffer( x , y , ExRateX , ExRateY , String , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendVStringToZBuffer")]
		extern static int  dx_DrawExtendVStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode);
		public static int  DrawExtendVStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode)
		{
			return dx_DrawExtendVStringToZBuffer( x , y , ExRateX , ExRateY , String , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendStringToHandleToZBuffer")]
		extern static int  dx_DrawExtendStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		public static int  DrawExtendStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode)
		{
			return dx_DrawExtendStringToHandleToZBuffer( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode , FALSE );
		}
		public static int  DrawExtendStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag)
		{
			return dx_DrawExtendStringToHandleToZBuffer( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendVStringToHandleToZBuffer")]
		extern static int  dx_DrawExtendVStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode);
		public static int  DrawExtendVStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode)
		{
			return dx_DrawExtendVStringToHandleToZBuffer( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonBase")]
		extern static int  dx_DrawPolygonBase( out VERTEX  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag, int  UVScaling);
		public static int  DrawPolygonBase( out VERTEX  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPolygonBase( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawPolygonBase( out VERTEX  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag, int  UVScaling)
		{
			return dx_DrawPolygonBase( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag , UVScaling );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon")]
		extern static int  dx_DrawPolygon( out VERTEX  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag, int  UVScaling);
		public static int  DrawPolygon( out VERTEX  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPolygon( out Vertex , PolygonNum , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawPolygon( out VERTEX  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag, int  UVScaling)
		{
			return dx_DrawPolygon( out Vertex , PolygonNum , GrHandle , TransFlag , UVScaling );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive2D")]
		extern static int  dx_DrawPrimitive2D( out VERTEX2D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive2D( out VERTEX2D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPrimitive2D( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed2D")]
		extern static int  dx_DrawPrimitiveIndexed2D( out VERTEX2D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed2D( out VERTEX2D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPrimitiveIndexed2D( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3D")]
		extern static int  dx_DrawPrimitive3D( out VERTEX3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive3D( out VERTEX3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPrimitive3D( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3D")]
		extern static int  dx_DrawPrimitiveIndexed3D( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed3D( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPrimitiveIndexed3D( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3D_UseVertexBuffer")]
		extern static int  dx_DrawPrimitive3D_UseVertexBuffer( int  VertexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive3D_UseVertexBuffer( int  VertexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPrimitive3D_UseVertexBuffer( VertexBufHandle , PrimitiveType , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3D_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitive3D_UseVertexBuffer2( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive3D_UseVertexBuffer2( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPrimitive3D_UseVertexBuffer2( VertexBufHandle , PrimitiveType , StartVertex , UseVertexNum , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3D_UseVertexBuffer")]
		extern static int  dx_DrawPrimitiveIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPrimitiveIndexed3D_UseVertexBuffer( VertexBufHandle , IndexBufHandle , PrimitiveType , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3D_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitiveIndexed3D_UseVertexBuffer2( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed3D_UseVertexBuffer2( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPrimitiveIndexed3D_UseVertexBuffer2( VertexBufHandle , IndexBufHandle , PrimitiveType , BaseVertex , StartVertex , UseVertexNum , StartIndex , UseIndexNum , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3D")]
		extern static int  dx_DrawPolygon3D( out VERTEX3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3D( out VERTEX3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPolygon3D( out Vertex , PolygonNum , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed3D")]
		extern static int  dx_DrawPolygonIndexed3D( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed3D( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPolygonIndexed3D( out Vertex , VertexNum , out Indices , PolygonNum , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3D_UseVertexBuffer")]
		extern static int  dx_DrawPolygon3D_UseVertexBuffer( int  VertexBufHandle, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3D_UseVertexBuffer( int  VertexBufHandle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPolygon3D_UseVertexBuffer( VertexBufHandle , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed3D_UseVertexBuffer")]
		extern static int  dx_DrawPolygonIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPolygonIndexed3D_UseVertexBuffer( VertexBufHandle , IndexBufHandle , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed3DBase")]
		extern static int  dx_DrawPolygonIndexed3DBase( out VERTEX_3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed3DBase( out VERTEX_3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPolygonIndexed3DBase( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3DBase")]
		extern static int  dx_DrawPolygon3DBase( out VERTEX_3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3DBase( out VERTEX_3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPolygon3DBase( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3D_2")]
		extern static int  dx_DrawPolygon3D_2( out VERTEX_3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3D( out VERTEX_3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			return dx_DrawPolygon3D_2( out Vertex , PolygonNum , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawGraph3D")]
		extern static int  dx_DrawGraph3D( float  x, float  y, float  z, int  GrHandle, int  TransFlag);
		public static int  DrawGraph3D( float  x, float  y, float  z, int  GrHandle, int  TransFlag)
		{
			return dx_DrawGraph3D( x , y , z , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendGraph3D")]
		extern static int  dx_DrawExtendGraph3D( float  x, float  y, float  z, double  ExRateX, double  ExRateY, int  GrHandle, int  TransFlag);
		public static int  DrawExtendGraph3D( float  x, float  y, float  z, double  ExRateX, double  ExRateY, int  GrHandle, int  TransFlag)
		{
			return dx_DrawExtendGraph3D( x , y , z , ExRateX , ExRateY , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph3D")]
		extern static int  dx_DrawRotaGraph3D( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph3D( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawRotaGraph3D( x , y , z , ExRate , Angle , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawRotaGraph3D( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRotaGraph3D( x , y , z , ExRate , Angle , GrHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRota2Graph3D")]
		extern static int  dx_DrawRota2Graph3D( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRota2Graph3D( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawRota2Graph3D( x , y , z , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawRota2Graph3D( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawRota2Graph3D( x , y , z , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawModiBillboard3D")]
		extern static int  dx_DrawModiBillboard3D( VECTOR  Pos, float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag);
		public static int  DrawModiBillboard3D( VECTOR  Pos, float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag)
		{
			return dx_DrawModiBillboard3D( Pos , x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBillboard3D")]
		extern static int  dx_DrawBillboard3D( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawBillboard3D( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag)
		{
			return dx_DrawBillboard3D( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawBillboard3D( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			return dx_DrawBillboard3D( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , TurnFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FillGraph")]
		extern static int  dx_FillGraph( int  GrHandle, int  Red, int  Green, int  Blue, int  Alpha);
		public static int  FillGraph( int  GrHandle, int  Red, int  Green, int  Blue)
		{
			return dx_FillGraph( GrHandle , Red , Green , Blue , 255 );
		}
		public static int  FillGraph( int  GrHandle, int  Red, int  Green, int  Blue, int  Alpha)
		{
			return dx_FillGraph( GrHandle , Red , Green , Blue , Alpha );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLine")]
		extern static int  dx_DrawLine( int  x1, int  y1, int  x2, int  y2, int  Color, int  Thickness);
		public static int  DrawLine( int  x1, int  y1, int  x2, int  y2, int  Color)
		{
			return dx_DrawLine( x1 , y1 , x2 , y2 , Color , 1 );
		}
		public static int  DrawLine( int  x1, int  y1, int  x2, int  y2, int  Color, int  Thickness)
		{
			return dx_DrawLine( x1 , y1 , x2 , y2 , Color , Thickness );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBox")]
		extern static int  dx_DrawBox( int  x1, int  y1, int  x2, int  y2, int  Color, int  FillFlag);
		public static int  DrawBox( int  x1, int  y1, int  x2, int  y2, int  Color, int  FillFlag)
		{
			return dx_DrawBox( x1 , y1 , x2 , y2 , Color , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawFillBox")]
		extern static int  dx_DrawFillBox( int  x1, int  y1, int  x2, int  y2, int  Color);
		public static int  DrawFillBox( int  x1, int  y1, int  x2, int  y2, int  Color)
		{
			return dx_DrawFillBox( x1 , y1 , x2 , y2 , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLineBox")]
		extern static int  dx_DrawLineBox( int  x1, int  y1, int  x2, int  y2, int  Color);
		public static int  DrawLineBox( int  x1, int  y1, int  x2, int  y2, int  Color)
		{
			return dx_DrawLineBox( x1 , y1 , x2 , y2 , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCircle")]
		extern static int  dx_DrawCircle( int  x, int  y, int  r, int  Color, int  FillFlag);
		public static int  DrawCircle( int  x, int  y, int  r, int  Color)
		{
			return dx_DrawCircle( x , y , r , Color , TRUE );
		}
		public static int  DrawCircle( int  x, int  y, int  r, int  Color, int  FillFlag)
		{
			return dx_DrawCircle( x , y , r , Color , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawOval")]
		extern static int  dx_DrawOval( int  x, int  y, int  rx, int  ry, int  Color, int  FillFlag);
		public static int  DrawOval( int  x, int  y, int  rx, int  ry, int  Color, int  FillFlag)
		{
			return dx_DrawOval( x , y , rx , ry , Color , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTriangle")]
		extern static int  dx_DrawTriangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  Color, int  FillFlag);
		public static int  DrawTriangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  Color, int  FillFlag)
		{
			return dx_DrawTriangle( x1 , y1 , x2 , y2 , x3 , y3 , Color , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawQuadrangle")]
		extern static int  dx_DrawQuadrangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  Color, int  FillFlag);
		public static int  DrawQuadrangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  Color, int  FillFlag)
		{
			return dx_DrawQuadrangle( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixel")]
		extern static int  dx_DrawPixel( int  x, int  y, int  Color);
		public static int  DrawPixel( int  x, int  y, int  Color)
		{
			return dx_DrawPixel( x , y , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelSet")]
		extern static int  dx_DrawPixelSet( out POINTDATA  PointData, int  Num);
		public static int  DrawPixelSet( out POINTDATA  PointData, int  Num)
		{
			return dx_DrawPixelSet( out PointData , Num );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLineSet")]
		extern static int  dx_DrawLineSet( out LINEDATA  LineData, int  Num);
		public static int  DrawLineSet( out LINEDATA  LineData, int  Num)
		{
			return dx_DrawLineSet( out LineData , Num );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixel3D")]
		extern static int  dx_DrawPixel3D( VECTOR  Pos, int  Color);
		public static int  DrawPixel3D( VECTOR  Pos, int  Color)
		{
			return dx_DrawPixel3D( Pos , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLine3D")]
		extern static int  dx_DrawLine3D( VECTOR  Pos1, VECTOR  Pos2, int  Color);
		public static int  DrawLine3D( VECTOR  Pos1, VECTOR  Pos2, int  Color)
		{
			return dx_DrawLine3D( Pos1 , Pos2 , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTriangle3D")]
		extern static int  dx_DrawTriangle3D( VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3, int  Color, int  FillFlag);
		public static int  DrawTriangle3D( VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3, int  Color, int  FillFlag)
		{
			return dx_DrawTriangle3D( Pos1 , Pos2 , Pos3 , Color , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCube3D")]
		extern static int  dx_DrawCube3D( VECTOR  Pos1, VECTOR  Pos2, int  DifColor, int  SpcColor, int  FillFlag);
		public static int  DrawCube3D( VECTOR  Pos1, VECTOR  Pos2, int  DifColor, int  SpcColor, int  FillFlag)
		{
			return dx_DrawCube3D( Pos1 , Pos2 , DifColor , SpcColor , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawSphere3D")]
		extern static int  dx_DrawSphere3D( VECTOR  CenterPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag);
		public static int  DrawSphere3D( VECTOR  CenterPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag)
		{
			return dx_DrawSphere3D( CenterPos , r , DivNum , DifColor , SpcColor , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCapsule3D")]
		extern static int  dx_DrawCapsule3D( VECTOR  Pos1, VECTOR  Pos2, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag);
		public static int  DrawCapsule3D( VECTOR  Pos1, VECTOR  Pos2, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag)
		{
			return dx_DrawCapsule3D( Pos1 , Pos2 , r , DivNum , DifColor , SpcColor , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCone3D")]
		extern static int  dx_DrawCone3D( VECTOR  TopPos, VECTOR  BottomPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag);
		public static int  DrawCone3D( VECTOR  TopPos, VECTOR  BottomPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag)
		{
			return dx_DrawCone3D( TopPos , BottomPos , r , DivNum , DifColor , SpcColor , FillFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawString")]
		extern static int  dx_DrawString( int  x, int  y, string  String, int  Color, int  EdgeColor);
		public static int  DrawString( int  x, int  y, string  String, int  Color)
		{
			return dx_DrawString( x , y , String , Color , 0 );
		}
		public static int  DrawString( int  x, int  y, string  String, int  Color, int  EdgeColor)
		{
			return dx_DrawString( x , y , String , Color , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawVString")]
		extern static int  dx_DrawVString( int  x, int  y, string  String, int  Color, int  EdgeColor);
		public static int  DrawVString( int  x, int  y, string  String, int  Color)
		{
			return dx_DrawVString( x , y , String , Color , 0 );
		}
		public static int  DrawVString( int  x, int  y, string  String, int  Color, int  EdgeColor)
		{
			return dx_DrawVString( x , y , String , Color , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringToHandle")]
		extern static int  dx_DrawStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag);
		public static int  DrawStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle)
		{
			return dx_DrawStringToHandle( x , y , String , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor)
		{
			return dx_DrawStringToHandle( x , y , String , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag)
		{
			return dx_DrawStringToHandle( x , y , String , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawVStringToHandle")]
		extern static int  dx_DrawVStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawVStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle)
		{
			return dx_DrawVStringToHandle( x , y , String , Color , FontHandle , 0 );
		}
		public static int  DrawVStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor)
		{
			return dx_DrawVStringToHandle( x , y , String , Color , FontHandle , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendString")]
		extern static int  dx_DrawExtendString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor);
		public static int  DrawExtendString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color)
		{
			return dx_DrawExtendString( x , y , ExRateX , ExRateY , String , Color , 0 );
		}
		public static int  DrawExtendString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor)
		{
			return dx_DrawExtendString( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendVString")]
		extern static int  dx_DrawExtendVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor);
		public static int  DrawExtendVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color)
		{
			return dx_DrawExtendVString( x , y , ExRateX , ExRateY , String , Color , 0 );
		}
		public static int  DrawExtendVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor)
		{
			return dx_DrawExtendVString( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendStringToHandle")]
		extern static int  dx_DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag);
		public static int  DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle)
		{
			return dx_DrawExtendStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor)
		{
			return dx_DrawExtendStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag)
		{
			return dx_DrawExtendStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendVStringToHandle")]
		extern static int  dx_DrawExtendVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawExtendVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle)
		{
			return dx_DrawExtendVStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 );
		}
		public static int  DrawExtendVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor)
		{
			return dx_DrawExtendVStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberToI")]
		extern static int  dx_DrawNumberToI( int  x, int  y, int  Num, int  RisesNum, int  Color, int  EdgeColor);
		public static int  DrawNumberToI( int  x, int  y, int  Num, int  RisesNum, int  Color)
		{
			return dx_DrawNumberToI( x , y , Num , RisesNum , Color , 0 );
		}
		public static int  DrawNumberToI( int  x, int  y, int  Num, int  RisesNum, int  Color, int  EdgeColor)
		{
			return dx_DrawNumberToI( x , y , Num , RisesNum , Color , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberToF")]
		extern static int  dx_DrawNumberToF( int  x, int  y, double  Num, int  Length, int  Color, int  EdgeColor);
		public static int  DrawNumberToF( int  x, int  y, double  Num, int  Length, int  Color)
		{
			return dx_DrawNumberToF( x , y , Num , Length , Color , 0 );
		}
		public static int  DrawNumberToF( int  x, int  y, double  Num, int  Length, int  Color, int  EdgeColor)
		{
			return dx_DrawNumberToF( x , y , Num , Length , Color , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberPlusToI")]
		extern static int  dx_DrawNumberPlusToI( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  EdgeColor);
		public static int  DrawNumberPlusToI( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color)
		{
			return dx_DrawNumberPlusToI( x , y , NoteString , Num , RisesNum , Color , 0 );
		}
		public static int  DrawNumberPlusToI( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  EdgeColor)
		{
			return dx_DrawNumberPlusToI( x , y , NoteString , Num , RisesNum , Color , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberPlusToF")]
		extern static int  dx_DrawNumberPlusToF( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  EdgeColor);
		public static int  DrawNumberPlusToF( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color)
		{
			return dx_DrawNumberPlusToF( x , y , NoteString , Num , Length , Color , 0 );
		}
		public static int  DrawNumberPlusToF( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  EdgeColor)
		{
			return dx_DrawNumberPlusToF( x , y , NoteString , Num , Length , Color , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberToIToHandle")]
		extern static int  dx_DrawNumberToIToHandle( int  x, int  y, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawNumberToIToHandle( int  x, int  y, int  Num, int  RisesNum, int  Color, int  FontHandle)
		{
			return dx_DrawNumberToIToHandle( x , y , Num , RisesNum , Color , FontHandle , 0 );
		}
		public static int  DrawNumberToIToHandle( int  x, int  y, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor)
		{
			return dx_DrawNumberToIToHandle( x , y , Num , RisesNum , Color , FontHandle , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberToFToHandle")]
		extern static int  dx_DrawNumberToFToHandle( int  x, int  y, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawNumberToFToHandle( int  x, int  y, double  Num, int  Length, int  Color, int  FontHandle)
		{
			return dx_DrawNumberToFToHandle( x , y , Num , Length , Color , FontHandle , 0 );
		}
		public static int  DrawNumberToFToHandle( int  x, int  y, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor)
		{
			return dx_DrawNumberToFToHandle( x , y , Num , Length , Color , FontHandle , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberPlusToIToHandle")]
		extern static int  dx_DrawNumberPlusToIToHandle( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawNumberPlusToIToHandle( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  FontHandle)
		{
			return dx_DrawNumberPlusToIToHandle( x , y , NoteString , Num , RisesNum , Color , FontHandle , 0 );
		}
		public static int  DrawNumberPlusToIToHandle( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor)
		{
			return dx_DrawNumberPlusToIToHandle( x , y , NoteString , Num , RisesNum , Color , FontHandle , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberPlusToFToHandle")]
		extern static int  dx_DrawNumberPlusToFToHandle( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawNumberPlusToFToHandle( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  FontHandle)
		{
			return dx_DrawNumberPlusToFToHandle( x , y , NoteString , Num , Length , Color , FontHandle , 0 );
		}
		public static int  DrawNumberPlusToFToHandle( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor)
		{
			return dx_DrawNumberPlusToFToHandle( x , y , NoteString , Num , Length , Color , FontHandle , EdgeColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateVertexBuffer")]
		extern static int  dx_CreateVertexBuffer( int  VertexNum, int  VertexType);
		public static int  CreateVertexBuffer( int  VertexNum, int  VertexType)
		{
			return dx_CreateVertexBuffer( VertexNum , VertexType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteVertexBuffer")]
		extern static int  dx_DeleteVertexBuffer( int  VertexBufHandle);
		public static int  DeleteVertexBuffer( int  VertexBufHandle)
		{
			return dx_DeleteVertexBuffer( VertexBufHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitVertexBuffer")]
		extern static int  dx_InitVertexBuffer( );
		public static int  InitVertexBuffer( )
		{
			return dx_InitVertexBuffer( );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_SetVertexBufferData")]
		extern unsafe static int  dx_SetVertexBufferData( int  SetIndex, void *  VertexData, int  VertexNum, int  VertexBufHandle);
		public unsafe static int  SetVertexBufferData( int  SetIndex, void *  VertexData, int  VertexNum, int  VertexBufHandle)
		{
			return dx_SetVertexBufferData( SetIndex , VertexData , VertexNum , VertexBufHandle );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_CreateIndexBuffer")]
		extern static int  dx_CreateIndexBuffer( int  IndexNum, int  IndexType);
		public static int  CreateIndexBuffer( int  IndexNum, int  IndexType)
		{
			return dx_CreateIndexBuffer( IndexNum , IndexType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteIndexBuffer")]
		extern static int  dx_DeleteIndexBuffer( int  IndexBufHandle);
		public static int  DeleteIndexBuffer( int  IndexBufHandle)
		{
			return dx_DeleteIndexBuffer( IndexBufHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitIndexBuffer")]
		extern static int  dx_InitIndexBuffer( );
		public static int  InitIndexBuffer( )
		{
			return dx_InitIndexBuffer( );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_SetIndexBufferData")]
		extern unsafe static int  dx_SetIndexBufferData( int  SetIndex, void *  IndexData, int  IndexNum, int  IndexBufHandle);
		public unsafe static int  SetIndexBufferData( int  SetIndex, void *  IndexData, int  IndexNum, int  IndexBufHandle)
		{
			return dx_SetIndexBufferData( SetIndex , IndexData , IndexNum , IndexBufHandle );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_GetValidShaderVersion")]
		extern static int  dx_GetValidShaderVersion( );
		public static int  GetValidShaderVersion( )
		{
			return dx_GetValidShaderVersion( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadVertexShader")]
		extern static int  dx_LoadVertexShader( string  FileName);
		public static int  LoadVertexShader( string  FileName)
		{
			return dx_LoadVertexShader( FileName );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadVertexShaderFromMem")]
		extern unsafe static int  dx_LoadVertexShaderFromMem( void *  ImageAddress, int  ImageSize);
		public unsafe static int  LoadVertexShaderFromMem( void *  ImageAddress, int  ImageSize)
		{
			return dx_LoadVertexShaderFromMem( ImageAddress , ImageSize );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_LoadPixelShader")]
		extern static int  dx_LoadPixelShader( string  FileName);
		public static int  LoadPixelShader( string  FileName)
		{
			return dx_LoadPixelShader( FileName );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadPixelShaderFromMem")]
		extern unsafe static int  dx_LoadPixelShaderFromMem( void *  ImageAddress, int  ImageSize);
		public unsafe static int  LoadPixelShaderFromMem( void *  ImageAddress, int  ImageSize)
		{
			return dx_LoadPixelShaderFromMem( ImageAddress , ImageSize );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteShader")]
		extern static int  dx_DeleteShader( int  ShaderHandle);
		public static int  DeleteShader( int  ShaderHandle)
		{
			return dx_DeleteShader( ShaderHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitShader")]
		extern static int  dx_InitShader( );
		public static int  InitShader( )
		{
			return dx_InitShader( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetConstIndexToShader")]
		extern static int  dx_GetConstIndexToShader( string  ConstantName, int  ShaderHandle);
		public static int  GetConstIndexToShader( string  ConstantName, int  ShaderHandle)
		{
			return dx_GetConstIndexToShader( ConstantName , ShaderHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetConstCountToShader")]
		extern static int  dx_GetConstCountToShader( string  ConstantName, int  ShaderHandle);
		public static int  GetConstCountToShader( string  ConstantName, int  ShaderHandle)
		{
			return dx_GetConstCountToShader( ConstantName , ShaderHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstSF")]
		extern static int  dx_SetVSConstSF( int  ConstantIndex, float  Param);
		public static int  SetVSConstSF( int  ConstantIndex, float  Param)
		{
			return dx_SetVSConstSF( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstF")]
		extern static int  dx_SetVSConstF( int  ConstantIndex, FLOAT4  Param);
		public static int  SetVSConstF( int  ConstantIndex, FLOAT4  Param)
		{
			return dx_SetVSConstF( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstFMtx")]
		extern static int  dx_SetVSConstFMtx( int  ConstantIndex, MATRIX  Param);
		public static int  SetVSConstFMtx( int  ConstantIndex, MATRIX  Param)
		{
			return dx_SetVSConstFMtx( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstSI")]
		extern static int  dx_SetVSConstSI( int  ConstantIndex, int  Param);
		public static int  SetVSConstSI( int  ConstantIndex, int  Param)
		{
			return dx_SetVSConstSI( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstI")]
		extern static int  dx_SetVSConstI( int  ConstantIndex, INT4  Param);
		public static int  SetVSConstI( int  ConstantIndex, INT4  Param)
		{
			return dx_SetVSConstI( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstB")]
		extern static int  dx_SetVSConstB( int  ConstantIndex, int  Param);
		public static int  SetVSConstB( int  ConstantIndex, int  Param)
		{
			return dx_SetVSConstB( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstSFArray")]
		extern static int  dx_SetVSConstSFArray( int  ConstantIndex, out float  ParamArray, int  ParamNum);
		public static int  SetVSConstSFArray( int  ConstantIndex, out float  ParamArray, int  ParamNum)
		{
			return dx_SetVSConstSFArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstFArray")]
		extern static int  dx_SetVSConstFArray( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum);
		public static int  SetVSConstFArray( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum)
		{
			return dx_SetVSConstFArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstFMtxArray")]
		extern static int  dx_SetVSConstFMtxArray( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		public static int  SetVSConstFMtxArray( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum)
		{
			return dx_SetVSConstFMtxArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstSIArray")]
		extern static int  dx_SetVSConstSIArray( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		public static int  SetVSConstSIArray( int  ConstantIndex, out int  ParamArray, int  ParamNum)
		{
			return dx_SetVSConstSIArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstIArray")]
		extern static int  dx_SetVSConstIArray( int  ConstantIndex, out INT4  ParamArray, int  ParamNum);
		public static int  SetVSConstIArray( int  ConstantIndex, out INT4  ParamArray, int  ParamNum)
		{
			return dx_SetVSConstIArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstBArray")]
		extern static int  dx_SetVSConstBArray( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		public static int  SetVSConstBArray( int  ConstantIndex, out int  ParamArray, int  ParamNum)
		{
			return dx_SetVSConstBArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstSF")]
		extern static int  dx_SetPSConstSF( int  ConstantIndex, float  Param);
		public static int  SetPSConstSF( int  ConstantIndex, float  Param)
		{
			return dx_SetPSConstSF( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstF")]
		extern static int  dx_SetPSConstF( int  ConstantIndex, FLOAT4  Param);
		public static int  SetPSConstF( int  ConstantIndex, FLOAT4  Param)
		{
			return dx_SetPSConstF( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstFMtx")]
		extern static int  dx_SetPSConstFMtx( int  ConstantIndex, MATRIX  Param);
		public static int  SetPSConstFMtx( int  ConstantIndex, MATRIX  Param)
		{
			return dx_SetPSConstFMtx( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstSI")]
		extern static int  dx_SetPSConstSI( int  ConstantIndex, int  Param);
		public static int  SetPSConstSI( int  ConstantIndex, int  Param)
		{
			return dx_SetPSConstSI( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstI")]
		extern static int  dx_SetPSConstI( int  ConstantIndex, INT4  Param);
		public static int  SetPSConstI( int  ConstantIndex, INT4  Param)
		{
			return dx_SetPSConstI( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstB")]
		extern static int  dx_SetPSConstB( int  ConstantIndex, int  Param);
		public static int  SetPSConstB( int  ConstantIndex, int  Param)
		{
			return dx_SetPSConstB( ConstantIndex , Param );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstSFArray")]
		extern static int  dx_SetPSConstSFArray( int  ConstantIndex, out float  ParamArray, int  ParamNum);
		public static int  SetPSConstSFArray( int  ConstantIndex, out float  ParamArray, int  ParamNum)
		{
			return dx_SetPSConstSFArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstFArray")]
		extern static int  dx_SetPSConstFArray( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum);
		public static int  SetPSConstFArray( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum)
		{
			return dx_SetPSConstFArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstFMtxArray")]
		extern static int  dx_SetPSConstFMtxArray( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		public static int  SetPSConstFMtxArray( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum)
		{
			return dx_SetPSConstFMtxArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstSIArray")]
		extern static int  dx_SetPSConstSIArray( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		public static int  SetPSConstSIArray( int  ConstantIndex, out int  ParamArray, int  ParamNum)
		{
			return dx_SetPSConstSIArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstIArray")]
		extern static int  dx_SetPSConstIArray( int  ConstantIndex, out INT4  ParamArray, int  ParamNum);
		public static int  SetPSConstIArray( int  ConstantIndex, out INT4  ParamArray, int  ParamNum)
		{
			return dx_SetPSConstIArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstBArray")]
		extern static int  dx_SetPSConstBArray( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		public static int  SetPSConstBArray( int  ConstantIndex, out int  ParamArray, int  ParamNum)
		{
			return dx_SetPSConstBArray( ConstantIndex , out ParamArray , ParamNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseTextureToShader")]
		extern static int  dx_SetUseTextureToShader( int  StageIndex, int  GraphHandle);
		public static int  SetUseTextureToShader( int  StageIndex, int  GraphHandle)
		{
			return dx_SetUseTextureToShader( StageIndex , GraphHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseVertexShader")]
		extern static int  dx_SetUseVertexShader( int  ShaderHandle);
		public static int  SetUseVertexShader( int  ShaderHandle)
		{
			return dx_SetUseVertexShader( ShaderHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUsePixelShader")]
		extern static int  dx_SetUsePixelShader( int  ShaderHandle);
		public static int  SetUsePixelShader( int  ShaderHandle)
		{
			return dx_SetUsePixelShader( ShaderHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive2DToShader")]
		extern static int  dx_DrawPrimitive2DToShader( out VERTEX2DSHADER  Vertex, int  VertexNum, int  PrimitiveType);
		public static int  DrawPrimitive2DToShader( out VERTEX2DSHADER  Vertex, int  VertexNum, int  PrimitiveType)
		{
			return dx_DrawPrimitive2DToShader( out Vertex , VertexNum , PrimitiveType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3DToShader")]
		extern static int  dx_DrawPrimitive3DToShader( out VERTEX3DSHADER  Vertex, int  VertexNum, int  PrimitiveType);
		public static int  DrawPrimitive3DToShader( out VERTEX3DSHADER  Vertex, int  VertexNum, int  PrimitiveType)
		{
			return dx_DrawPrimitive3DToShader( out Vertex , VertexNum , PrimitiveType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed2DToShader")]
		extern static int  dx_DrawPrimitiveIndexed2DToShader( out VERTEX2DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType);
		public static int  DrawPrimitiveIndexed2DToShader( out VERTEX2DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType)
		{
			return dx_DrawPrimitiveIndexed2DToShader( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3DToShader")]
		extern static int  dx_DrawPrimitiveIndexed3DToShader( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType);
		public static int  DrawPrimitiveIndexed3DToShader( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType)
		{
			return dx_DrawPrimitiveIndexed3DToShader( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawMode")]
		extern static int  dx_SetDrawMode( int  DrawMode);
		public static int  SetDrawMode( int  DrawMode)
		{
			return dx_SetDrawMode( DrawMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaxAnisotropy")]
		extern static int  dx_SetMaxAnisotropy( int  MaxAnisotropy);
		public static int  SetMaxAnisotropy( int  MaxAnisotropy)
		{
			return dx_SetMaxAnisotropy( MaxAnisotropy );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawBlendMode")]
		extern static int  dx_SetDrawBlendMode( int  BlendMode, int  BlendParam);
		public static int  SetDrawBlendMode( int  BlendMode, int  BlendParam)
		{
			return dx_SetDrawBlendMode( BlendMode , BlendParam );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawAlphaTest")]
		extern static int  dx_SetDrawAlphaTest( int  TestMode, int  TestParam);
		public static int  SetDrawAlphaTest( int  TestMode, int  TestParam)
		{
			return dx_SetDrawAlphaTest( TestMode , TestParam );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBlendGraph")]
		extern static int  dx_SetBlendGraph( int  BlendGraph, int  BorderParam, int  BorderRange);
		public static int  SetBlendGraph( int  BlendGraph, int  BorderParam, int  BorderRange)
		{
			return dx_SetBlendGraph( BlendGraph , BorderParam , BorderRange );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBlendGraphPosition")]
		extern static int  dx_SetBlendGraphPosition( int  x, int  y);
		public static int  SetBlendGraphPosition( int  x, int  y)
		{
			return dx_SetBlendGraphPosition( x , y );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawBright")]
		extern static int  dx_SetDrawBright( int  RedBright, int  GreenBright, int  BlueBright);
		public static int  SetDrawBright( int  RedBright, int  GreenBright, int  BlueBright)
		{
			return dx_SetDrawBright( RedBright , GreenBright , BlueBright );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetIgnoreDrawGraphColor")]
		extern static int  dx_SetIgnoreDrawGraphColor( int  EnableFlag);
		public static int  SetIgnoreDrawGraphColor( int  EnableFlag)
		{
			return dx_SetIgnoreDrawGraphColor( EnableFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawScreen")]
		extern static int  dx_SetDrawScreen( int  DrawScreen);
		public static int  SetDrawScreen( int  DrawScreen)
		{
			return dx_SetDrawScreen( DrawScreen );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawArea")]
		extern static int  dx_SetDrawArea( int  x1, int  y1, int  x2, int  y2);
		public static int  SetDrawArea( int  x1, int  y1, int  x2, int  y2)
		{
			return dx_SetDrawArea( x1 , y1 , x2 , y2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDraw3DScale")]
		extern static int  dx_SetDraw3DScale( float  Scale);
		public static int  SetDraw3DScale( float  Scale)
		{
			return dx_SetDraw3DScale( Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawAreaFull")]
		extern static int  dx_SetDrawAreaFull( );
		public static int  SetDrawAreaFull( )
		{
			return dx_SetDrawAreaFull( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUse3DFlag")]
		extern static int  dx_SetUse3DFlag( int  Flag);
		public static int  SetUse3DFlag( int  Flag)
		{
			return dx_SetUse3DFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseHardwareVertexProcessing")]
		extern static int  dx_SetUseHardwareVertexProcessing( int  Flag);
		public static int  SetUseHardwareVertexProcessing( int  Flag)
		{
			return dx_SetUseHardwareVertexProcessing( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RunRestoreShred")]
		extern static int  dx_RunRestoreShred( );
		public static int  RunRestoreShred( )
		{
			return dx_RunRestoreShred( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransformToWorld")]
		extern static int  dx_SetTransformToWorld( out MATRIX  Matrix);
		public static int  SetTransformToWorld( out MATRIX  Matrix)
		{
			return dx_SetTransformToWorld( out Matrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransformToView")]
		extern static int  dx_SetTransformToView( out MATRIX  Matrix);
		public static int  SetTransformToView( out MATRIX  Matrix)
		{
			return dx_SetTransformToView( out Matrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransformToProjection")]
		extern static int  dx_SetTransformToProjection( out MATRIX  Matrix);
		public static int  SetTransformToProjection( out MATRIX  Matrix)
		{
			return dx_SetTransformToProjection( out Matrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransformToViewport")]
		extern static int  dx_SetTransformToViewport( out MATRIX  Matrix);
		public static int  SetTransformToViewport( out MATRIX  Matrix)
		{
			return dx_SetTransformToViewport( out Matrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseCullingFlag")]
		extern static int  dx_SetUseCullingFlag( int  Flag);
		public static int  SetUseCullingFlag( int  Flag)
		{
			return dx_SetUseCullingFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseBackCulling")]
		extern static int  dx_SetUseBackCulling( int  Flag);
		public static int  SetUseBackCulling( int  Flag)
		{
			return dx_SetUseBackCulling( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTextureAddressMode")]
		extern static int  dx_SetTextureAddressMode( int  Mode, int  Stage);
		public static int  SetTextureAddressMode( int  Mode)
		{
			return dx_SetTextureAddressMode( Mode , -1 );
		}
		public static int  SetTextureAddressMode( int  Mode, int  Stage)
		{
			return dx_SetTextureAddressMode( Mode , Stage );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTextureAddressModeUV")]
		extern static int  dx_SetTextureAddressModeUV( int  ModeU, int  ModeV, int  Stage);
		public static int  SetTextureAddressModeUV( int  ModeU, int  ModeV)
		{
			return dx_SetTextureAddressModeUV( ModeU , ModeV , -1 );
		}
		public static int  SetTextureAddressModeUV( int  ModeU, int  ModeV, int  Stage)
		{
			return dx_SetTextureAddressModeUV( ModeU , ModeV , Stage );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTextureAddressTransform")]
		extern static int  dx_SetTextureAddressTransform( float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate);
		public static int  SetTextureAddressTransform( float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate)
		{
			return dx_SetTextureAddressTransform( TransU , TransV , ScaleU , ScaleV , RotCenterU , RotCenterV , Rotate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTextureAddressTransformMatrix")]
		extern static int  dx_SetTextureAddressTransformMatrix( MATRIX  Matrix);
		public static int  SetTextureAddressTransformMatrix( MATRIX  Matrix)
		{
			return dx_SetTextureAddressTransformMatrix( Matrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetTextureAddressTransform")]
		extern static int  dx_ResetTextureAddressTransform( );
		public static int  ResetTextureAddressTransform( )
		{
			return dx_ResetTextureAddressTransform( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogEnable")]
		extern static int  dx_SetFogEnable( int  Flag);
		public static int  SetFogEnable( int  Flag)
		{
			return dx_SetFogEnable( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogMode")]
		extern static int  dx_SetFogMode( int  Mode);
		public static int  SetFogMode( int  Mode)
		{
			return dx_SetFogMode( Mode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogColor")]
		extern static int  dx_SetFogColor( int  r, int  g, int  b);
		public static int  SetFogColor( int  r, int  g, int  b)
		{
			return dx_SetFogColor( r , g , b );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogStartEnd")]
		extern static int  dx_SetFogStartEnd( float  start, float  end);
		public static int  SetFogStartEnd( float  start, float  end)
		{
			return dx_SetFogStartEnd( start , end );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogDensity")]
		extern static int  dx_SetFogDensity( float  density);
		public static int  SetFogDensity( float  density)
		{
			return dx_SetFogDensity( density );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseSystemMemGraphCreateFlag")]
		extern static int  dx_SetUseSystemMemGraphCreateFlag( int  Flag);
		public static int  SetUseSystemMemGraphCreateFlag( int  Flag)
		{
			return dx_SetUseSystemMemGraphCreateFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseVramFlag")]
		extern static int  dx_SetUseVramFlag( int  Flag);
		public static int  SetUseVramFlag( int  Flag)
		{
			return dx_SetUseVramFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RestoreGraphSystem")]
		extern static int  dx_RestoreGraphSystem( );
		public static int  RestoreGraphSystem( )
		{
			return dx_RestoreGraphSystem( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetAeroDisableFlag")]
		extern static int  dx_SetAeroDisableFlag( int  Flag);
		public static int  SetAeroDisableFlag( int  Flag)
		{
			return dx_SetAeroDisableFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawScreenGraph")]
		extern static int  dx_GetDrawScreenGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  UseClientFlag);
		public static int  GetDrawScreenGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle)
		{
			return dx_GetDrawScreenGraph( x1 , y1 , x2 , y2 , GrHandle , TRUE );
		}
		public static int  GetDrawScreenGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  UseClientFlag)
		{
			return dx_GetDrawScreenGraph( x1 , y1 , x2 , y2 , GrHandle , UseClientFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GraphUnLock")]
		extern static int  dx_GraphUnLock( int  GrHandle);
		public static int  GraphUnLock( int  GrHandle)
		{
			return dx_GraphUnLock( GrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseGraphZBuffer")]
		extern static int  dx_SetUseGraphZBuffer( int  GrHandle, int  UseFlag);
		public static int  SetUseGraphZBuffer( int  GrHandle, int  UseFlag)
		{
			return dx_SetUseGraphZBuffer( GrHandle , UseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CopyGraphZBufferImage")]
		extern static int  dx_CopyGraphZBufferImage( int  DestGrHandle, int  SrcGrHandle);
		public static int  CopyGraphZBufferImage( int  DestGrHandle, int  SrcGrHandle)
		{
			return dx_CopyGraphZBufferImage( DestGrHandle , SrcGrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphSize")]
		extern static int  dx_GetGraphSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf);
		public static int  GetGraphSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf)
		{
			return dx_GetGraphSize( GrHandle , out SizeXBuf , out SizeYBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphTextureSize")]
		extern static int  dx_GetGraphTextureSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf);
		public static int  GetGraphTextureSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf)
		{
			return dx_GetGraphTextureSize( GrHandle , out SizeXBuf , out SizeYBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphMipmapCount")]
		extern static int  dx_GetGraphMipmapCount( int  GrHandle);
		public static int  GetGraphMipmapCount( int  GrHandle)
		{
			return dx_GetGraphMipmapCount( GrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetScreenState")]
		extern static int  dx_GetScreenState( out int  SizeX, out int  SizeY, out int  ColorBitDepth);
		public static int  GetScreenState( out int  SizeX, out int  SizeY, out int  ColorBitDepth)
		{
			return dx_GetScreenState( out SizeX , out SizeY , out ColorBitDepth );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUse3DFlag")]
		extern static int  dx_GetUse3DFlag( );
		public static int  GetUse3DFlag( )
		{
			return dx_GetUse3DFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetValidRestoreShredPoint")]
		extern static int  dx_GetValidRestoreShredPoint( );
		public static int  GetValidRestoreShredPoint( )
		{
			return dx_GetValidRestoreShredPoint( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformToViewMatrix")]
		extern static int  dx_GetTransformToViewMatrix( out MATRIX  MatBuf);
		public static int  GetTransformToViewMatrix( out MATRIX  MatBuf)
		{
			return dx_GetTransformToViewMatrix( out MatBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformToWorldMatrix")]
		extern static int  dx_GetTransformToWorldMatrix( out MATRIX  MatBuf);
		public static int  GetTransformToWorldMatrix( out MATRIX  MatBuf)
		{
			return dx_GetTransformToWorldMatrix( out MatBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformToProjectionMatrix")]
		extern static int  dx_GetTransformToProjectionMatrix( out MATRIX  MatBuf);
		public static int  GetTransformToProjectionMatrix( out MATRIX  MatBuf)
		{
			return dx_GetTransformToProjectionMatrix( out MatBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformPosition")]
		extern static int  dx_GetTransformPosition( out VECTOR  LocalPos, out float  x, out float  y);
		public static int  GetTransformPosition( out VECTOR  LocalPos, out float  x, out float  y)
		{
			return dx_GetTransformPosition( out LocalPos , out x , out y );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetBillboardPixelSize")]
		extern static float  dx_GetBillboardPixelSize( VECTOR  WorldPos, float  WorldSize);
		public static float  GetBillboardPixelSize( VECTOR  WorldPos, float  WorldSize)
		{
			return dx_GetBillboardPixelSize( WorldPos , WorldSize );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvWorldPosToScreenPos")]
		extern static VECTOR  dx_ConvWorldPosToScreenPos( VECTOR  WorldPos);
		public static VECTOR  ConvWorldPosToScreenPos( VECTOR  WorldPos)
		{
			return dx_ConvWorldPosToScreenPos( WorldPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvWorldPosToScreenPosPlusW")]
		extern static FLOAT4  dx_ConvWorldPosToScreenPosPlusW( VECTOR  WorldPos);
		public static FLOAT4  ConvWorldPosToScreenPosPlusW( VECTOR  WorldPos)
		{
			return dx_ConvWorldPosToScreenPosPlusW( WorldPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvScreenPosToWorldPos")]
		extern static VECTOR  dx_ConvScreenPosToWorldPos( VECTOR  ScreenPos);
		public static VECTOR  ConvScreenPosToWorldPos( VECTOR  ScreenPos)
		{
			return dx_ConvScreenPosToWorldPos( ScreenPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvScreenPosToWorldPos_ZLinear")]
		extern static VECTOR  dx_ConvScreenPosToWorldPos_ZLinear( VECTOR  ScreenPos);
		public static VECTOR  ConvScreenPosToWorldPos_ZLinear( VECTOR  ScreenPos)
		{
			return dx_ConvScreenPosToWorldPos_ZLinear( ScreenPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseVramFlag")]
		extern static int  dx_GetUseVramFlag( );
		public static int  GetUseVramFlag( )
		{
			return dx_GetUseVramFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCreateGraphColorData")]
		extern static int  dx_GetCreateGraphColorData( out COLORDATA  ColorData, out IMAGEFORMATDESC  Format);
		public static int  GetCreateGraphColorData( out COLORDATA  ColorData, out IMAGEFORMATDESC  Format)
		{
			return dx_GetCreateGraphColorData( out ColorData , out Format );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DerivationGraph")]
		extern static int  dx_DerivationGraph( int  SrcX, int  SrcY, int  Width, int  Height, int  SrcGraphHandle);
		public static int  DerivationGraph( int  SrcX, int  SrcY, int  Width, int  Height, int  SrcGraphHandle)
		{
			return dx_DerivationGraph( SrcX , SrcY , Width , Height , SrcGraphHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMovie")]
		extern static int  dx_PlayMovie( string  FileName, int  ExRate, int  PlayType);
		public static int  PlayMovie( string  FileName, int  ExRate, int  PlayType)
		{
			return dx_PlayMovie( FileName , ExRate , PlayType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_OpenMovieToGraph")]
		extern static int  dx_OpenMovieToGraph( string  FileName, int  FullColor);
		public static int  OpenMovieToGraph( string  FileName)
		{
			return dx_OpenMovieToGraph( FileName , TRUE );
		}
		public static int  OpenMovieToGraph( string  FileName, int  FullColor)
		{
			return dx_OpenMovieToGraph( FileName , FullColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMovieToGraph")]
		extern static int  dx_PlayMovieToGraph( int  GraphHandle, int  PlayType, int  SysPlay);
		public static int  PlayMovieToGraph( int  GraphHandle)
		{
			return dx_PlayMovieToGraph( GraphHandle , DX_PLAYTYPE_BACK , 0 );
		}
		public static int  PlayMovieToGraph( int  GraphHandle, int  PlayType)
		{
			return dx_PlayMovieToGraph( GraphHandle , PlayType , 0 );
		}
		public static int  PlayMovieToGraph( int  GraphHandle, int  PlayType, int  SysPlay)
		{
			return dx_PlayMovieToGraph( GraphHandle , PlayType , SysPlay );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PauseMovieToGraph")]
		extern static int  dx_PauseMovieToGraph( int  GraphHandle, int  SysPause);
		public static int  PauseMovieToGraph( int  GraphHandle)
		{
			return dx_PauseMovieToGraph( GraphHandle , 0 );
		}
		public static int  PauseMovieToGraph( int  GraphHandle, int  SysPause)
		{
			return dx_PauseMovieToGraph( GraphHandle , SysPause );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMovieFrameToGraph")]
		extern static int  dx_AddMovieFrameToGraph( int  GraphHandle, uint  FrameNum);
		public static int  AddMovieFrameToGraph( int  GraphHandle, uint  FrameNum)
		{
			return dx_AddMovieFrameToGraph( GraphHandle , FrameNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SeekMovieToGraph")]
		extern static int  dx_SeekMovieToGraph( int  GraphHandle, int  Time);
		public static int  SeekMovieToGraph( int  GraphHandle, int  Time)
		{
			return dx_SeekMovieToGraph( GraphHandle , Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMovieStateToGraph")]
		extern static int  dx_GetMovieStateToGraph( int  GraphHandle);
		public static int  GetMovieStateToGraph( int  GraphHandle)
		{
			return dx_GetMovieStateToGraph( GraphHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMovieVolumeToGraph")]
		extern static int  dx_SetMovieVolumeToGraph( int  Volume, int  GraphHandle);
		public static int  SetMovieVolumeToGraph( int  Volume, int  GraphHandle)
		{
			return dx_SetMovieVolumeToGraph( Volume , GraphHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMovieTotalFrameToGraph")]
		extern static int  dx_GetMovieTotalFrameToGraph( int  GraphHandle);
		public static int  GetMovieTotalFrameToGraph( int  GraphHandle)
		{
			return dx_GetMovieTotalFrameToGraph( GraphHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_TellMovieToGraph")]
		extern static int  dx_TellMovieToGraph( int  GraphHandle);
		public static int  TellMovieToGraph( int  GraphHandle)
		{
			return dx_TellMovieToGraph( GraphHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_TellMovieToGraphToFrame")]
		extern static int  dx_TellMovieToGraphToFrame( int  GraphHandle);
		public static int  TellMovieToGraphToFrame( int  GraphHandle)
		{
			return dx_TellMovieToGraphToFrame( GraphHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SeekMovieToGraphToFrame")]
		extern static int  dx_SeekMovieToGraphToFrame( int  GraphHandle, int  Frame);
		public static int  SeekMovieToGraphToFrame( int  GraphHandle, int  Frame)
		{
			return dx_SeekMovieToGraphToFrame( GraphHandle , Frame );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetOneFrameTimeMovieToGraph")]
		extern static long  dx_GetOneFrameTimeMovieToGraph( int  GraphHandle);
		public static long  GetOneFrameTimeMovieToGraph( int  GraphHandle)
		{
			return dx_GetOneFrameTimeMovieToGraph( GraphHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLastUpdateTimeMovieToGraph")]
		extern static int  dx_GetLastUpdateTimeMovieToGraph( int  GraphHandle);
		public static int  GetLastUpdateTimeMovieToGraph( int  GraphHandle)
		{
			return dx_GetLastUpdateTimeMovieToGraph( GraphHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadBmpToGraph")]
		extern static int  dx_LoadBmpToGraph( string  GraphName, int  TextureFlag, int  ReverseFlag, int  SurfaceMode);
		public static int  LoadBmpToGraph( string  GraphName, int  TextureFlag, int  ReverseFlag)
		{
			return dx_LoadBmpToGraph( GraphName , TextureFlag , ReverseFlag , DX_MOVIESURFACE_NORMAL );
		}
		public static int  LoadBmpToGraph( string  GraphName, int  TextureFlag, int  ReverseFlag, int  SurfaceMode)
		{
			return dx_LoadBmpToGraph( GraphName , TextureFlag , ReverseFlag , SurfaceMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadGraph")]
		extern static int  dx_LoadGraph( string  FileName, int  NotUse3DFlag);
		public static int  LoadGraph( string  FileName)
		{
			return dx_LoadGraph( FileName , FALSE );
		}
		public static int  LoadGraph( string  FileName, int  NotUse3DFlag)
		{
			return dx_LoadGraph( FileName , NotUse3DFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadReverseGraph")]
		extern static int  dx_LoadReverseGraph( string  FileName, int  NotUse3DFlag);
		public static int  LoadReverseGraph( string  FileName)
		{
			return dx_LoadReverseGraph( FileName , FALSE );
		}
		public static int  LoadReverseGraph( string  FileName, int  NotUse3DFlag)
		{
			return dx_LoadReverseGraph( FileName , NotUse3DFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivGraph")]
		extern static int  dx_LoadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag);
		public static int  LoadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			return dx_LoadDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , FALSE );
		}
		public static int  LoadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag)
		{
			return dx_LoadDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , NotUse3DFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivBmpToGraph")]
		extern static int  dx_LoadDivBmpToGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf, int  TextureFlag, int  ReverseFlag);
		public static int  LoadDivBmpToGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf, int  TextureFlag, int  ReverseFlag)
		{
			return dx_LoadDivBmpToGraph( FileName , AllNum , XNum , YNum , SizeX , SizeY , out HandleBuf , TextureFlag , ReverseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadReverseDivGraph")]
		extern static int  dx_LoadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag);
		public static int  LoadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			return dx_LoadReverseDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , FALSE );
		}
		public static int  LoadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag)
		{
			return dx_LoadReverseDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , NotUse3DFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadBlendGraph")]
		extern static int  dx_LoadBlendGraph( string  FileName);
		public static int  LoadBlendGraph( string  FileName)
		{
			return dx_LoadBlendGraph( FileName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivGraphToResource")]
		extern static int  dx_LoadDivGraphToResource( int  ResourceID, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		public static int  LoadDivGraphToResource( int  ResourceID, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			return dx_LoadDivGraphToResource( ResourceID , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivGraphToResource_2")]
		extern static int  dx_LoadDivGraphToResource_2( string  ResourceName, string  ResourceType, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		public static int  LoadDivGraphToResource( string  ResourceName, string  ResourceType, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			return dx_LoadDivGraphToResource_2( ResourceName , ResourceType , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_CreateGraphFromMem")]
		extern unsafe static int  dx_CreateGraphFromMem( void *  MemImage, int  MemImageSize, void *  AlphaImage, int  AlphaImageSize, int  TextureFlag, int  ReverseFlag);
		public unsafe static int  CreateGraphFromMem( void *  MemImage, int  MemImageSize)
		{
			return dx_CreateGraphFromMem( MemImage , MemImageSize , null , 0 , TRUE , FALSE );
		}
		public unsafe static int  CreateGraphFromMem( void *  MemImage, int  MemImageSize, void *  AlphaImage)
		{
			return dx_CreateGraphFromMem( MemImage , MemImageSize , AlphaImage , 0 , TRUE , FALSE );
		}
		public unsafe static int  CreateGraphFromMem( void *  MemImage, int  MemImageSize, void *  AlphaImage, int  AlphaImageSize)
		{
			return dx_CreateGraphFromMem( MemImage , MemImageSize , AlphaImage , AlphaImageSize , TRUE , FALSE );
		}
		public unsafe static int  CreateGraphFromMem( void *  MemImage, int  MemImageSize, void *  AlphaImage, int  AlphaImageSize, int  TextureFlag)
		{
			return dx_CreateGraphFromMem( MemImage , MemImageSize , AlphaImage , AlphaImageSize , TextureFlag , FALSE );
		}
		public unsafe static int  CreateGraphFromMem( void *  MemImage, int  MemImageSize, void *  AlphaImage, int  AlphaImageSize, int  TextureFlag, int  ReverseFlag)
		{
			return dx_CreateGraphFromMem( MemImage , MemImageSize , AlphaImage , AlphaImageSize , TextureFlag , ReverseFlag );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateGraphFromMem")]
		extern unsafe static int  dx_ReCreateGraphFromMem( void *  MemImage, int  MemImageSize, int  GrHandle, void *  AlphaImage, int  AlphaImageSize, int  TextureFlag, int  ReverseFlag);
		public unsafe static int  ReCreateGraphFromMem( void *  MemImage, int  MemImageSize, int  GrHandle)
		{
			return dx_ReCreateGraphFromMem( MemImage , MemImageSize , GrHandle , null , 0 , TRUE , FALSE );
		}
		public unsafe static int  ReCreateGraphFromMem( void *  MemImage, int  MemImageSize, int  GrHandle, void *  AlphaImage)
		{
			return dx_ReCreateGraphFromMem( MemImage , MemImageSize , GrHandle , AlphaImage , 0 , TRUE , FALSE );
		}
		public unsafe static int  ReCreateGraphFromMem( void *  MemImage, int  MemImageSize, int  GrHandle, void *  AlphaImage, int  AlphaImageSize)
		{
			return dx_ReCreateGraphFromMem( MemImage , MemImageSize , GrHandle , AlphaImage , AlphaImageSize , TRUE , FALSE );
		}
		public unsafe static int  ReCreateGraphFromMem( void *  MemImage, int  MemImageSize, int  GrHandle, void *  AlphaImage, int  AlphaImageSize, int  TextureFlag)
		{
			return dx_ReCreateGraphFromMem( MemImage , MemImageSize , GrHandle , AlphaImage , AlphaImageSize , TextureFlag , FALSE );
		}
		public unsafe static int  ReCreateGraphFromMem( void *  MemImage, int  MemImageSize, int  GrHandle, void *  AlphaImage, int  AlphaImageSize, int  TextureFlag, int  ReverseFlag)
		{
			return dx_ReCreateGraphFromMem( MemImage , MemImageSize , GrHandle , AlphaImage , AlphaImageSize , TextureFlag , ReverseFlag );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_CreateDivGraphFromMem")]
		extern unsafe static int  dx_CreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaImage, int  AlphaImageSize);
		public unsafe static int  CreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf)
		{
			return dx_CreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TRUE , FALSE , null , 0 );
		}
		public unsafe static int  CreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag)
		{
			return dx_CreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , FALSE , null , 0 );
		}
		public unsafe static int  CreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag)
		{
			return dx_CreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , null , 0 );
		}
		public unsafe static int  CreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaImage)
		{
			return dx_CreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaImage , 0 );
		}
		public unsafe static int  CreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaImage, int  AlphaImageSize)
		{
			return dx_CreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaImage , AlphaImageSize );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateDivGraphFromMem")]
		extern unsafe static int  dx_ReCreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaImage, int  AlphaImageSize);
		public unsafe static int  ReCreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf)
		{
			return dx_ReCreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TRUE , FALSE , null , 0 );
		}
		public unsafe static int  ReCreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag)
		{
			return dx_ReCreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , FALSE , null , 0 );
		}
		public unsafe static int  ReCreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag)
		{
			return dx_ReCreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , null , 0 );
		}
		public unsafe static int  ReCreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaImage)
		{
			return dx_ReCreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaImage , 0 );
		}
		public unsafe static int  ReCreateDivGraphFromMem( void *  MemImage, int  MemImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaImage, int  AlphaImageSize)
		{
			return dx_ReCreateDivGraphFromMem( MemImage , MemImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaImage , AlphaImageSize );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_CreateGraph")]
		extern unsafe static int  dx_CreateGraph( int  Width, int  Height, int  Pitch, void *  GraphData, void *  AlphaData, int  GrHandle);
		public unsafe static int  CreateGraph( int  Width, int  Height, int  Pitch, void *  GraphData)
		{
			return dx_CreateGraph( Width , Height , Pitch , GraphData , null , -1 );
		}
		public unsafe static int  CreateGraph( int  Width, int  Height, int  Pitch, void *  GraphData, void *  AlphaData)
		{
			return dx_CreateGraph( Width , Height , Pitch , GraphData , AlphaData , -1 );
		}
		public unsafe static int  CreateGraph( int  Width, int  Height, int  Pitch, void *  GraphData, void *  AlphaData, int  GrHandle)
		{
			return dx_CreateGraph( Width , Height , Pitch , GraphData , AlphaData , GrHandle );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_CreateDivGraph")]
		extern unsafe static int  dx_CreateDivGraph( int  Width, int  Height, int  Pitch, void *  GraphData, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, void *  AlphaData);
		public unsafe static int  CreateDivGraph( int  Width, int  Height, int  Pitch, void *  GraphData, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf)
		{
			return dx_CreateDivGraph( Width , Height , Pitch , GraphData , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , null );
		}
		public unsafe static int  CreateDivGraph( int  Width, int  Height, int  Pitch, void *  GraphData, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, void *  AlphaData)
		{
			return dx_CreateDivGraph( Width , Height , Pitch , GraphData , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , AlphaData );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateGraph")]
		extern unsafe static int  dx_ReCreateGraph( int  Width, int  Height, int  Pitch, void *  GraphData, int  GrHandle, void *  AlphaData);
		public unsafe static int  ReCreateGraph( int  Width, int  Height, int  Pitch, void *  GraphData, int  GrHandle)
		{
			return dx_ReCreateGraph( Width , Height , Pitch , GraphData , GrHandle , null );
		}
		public unsafe static int  ReCreateGraph( int  Width, int  Height, int  Pitch, void *  GraphData, int  GrHandle, void *  AlphaData)
		{
			return dx_ReCreateGraph( Width , Height , Pitch , GraphData , GrHandle , AlphaData );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_CreateBlendGraphFromSoftImage")]
		extern static int  dx_CreateBlendGraphFromSoftImage( int  SIHandle);
		public static int  CreateBlendGraphFromSoftImage( int  SIHandle)
		{
			return dx_CreateBlendGraphFromSoftImage( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateGraphFromSoftImage")]
		extern static int  dx_CreateGraphFromSoftImage( int  SIHandle);
		public static int  CreateGraphFromSoftImage( int  SIHandle)
		{
			return dx_CreateGraphFromSoftImage( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateGraphFromRectSoftImage")]
		extern static int  dx_CreateGraphFromRectSoftImage( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY);
		public static int  CreateGraphFromRectSoftImage( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY)
		{
			return dx_CreateGraphFromRectSoftImage( SIHandle , x , y , SizeX , SizeY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateGraphFromSoftImage")]
		extern static int  dx_ReCreateGraphFromSoftImage( int  SIHandle, int  GrHandle);
		public static int  ReCreateGraphFromSoftImage( int  SIHandle, int  GrHandle)
		{
			return dx_ReCreateGraphFromSoftImage( SIHandle , GrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateGraphFromRectSoftImage")]
		extern static int  dx_ReCreateGraphFromRectSoftImage( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY, int  GrHandle);
		public static int  ReCreateGraphFromRectSoftImage( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY, int  GrHandle)
		{
			return dx_ReCreateGraphFromRectSoftImage( SIHandle , x , y , SizeX , SizeY , GrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateDivGraphFromSoftImage")]
		extern static int  dx_CreateDivGraphFromSoftImage( int  SIHandle, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf);
		public static int  CreateDivGraphFromSoftImage( int  SIHandle, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf)
		{
			return dx_CreateDivGraphFromSoftImage( SIHandle , AllNum , XNum , YNum , SizeX , SizeY , out HandleBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadGraph")]
		extern static int  dx_ReloadGraph( string  FileName, int  GrHandle, int  ReverseFlag);
		public static int  ReloadGraph( string  FileName, int  GrHandle)
		{
			return dx_ReloadGraph( FileName , GrHandle , FALSE );
		}
		public static int  ReloadGraph( string  FileName, int  GrHandle, int  ReverseFlag)
		{
			return dx_ReloadGraph( FileName , GrHandle , ReverseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadDivGraph")]
		extern static int  dx_ReloadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  ReverseFlag);
		public static int  ReloadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			return dx_ReloadDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , FALSE );
		}
		public static int  ReloadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  ReverseFlag)
		{
			return dx_ReloadDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , ReverseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadReverseGraph")]
		extern static int  dx_ReloadReverseGraph( string  FileName, int  GrHandle);
		public static int  ReloadReverseGraph( string  FileName, int  GrHandle)
		{
			return dx_ReloadReverseGraph( FileName , GrHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadReverseDivGraph")]
		extern static int  dx_ReloadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		public static int  ReloadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			return dx_ReloadReverseDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraNearFar")]
		extern static int  dx_SetCameraNearFar( float  Near, float  Far);
		public static int  SetCameraNearFar( float  Near, float  Far)
		{
			return dx_SetCameraNearFar( Near , Far );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraPositionAndTarget_UpVecY")]
		extern static int  dx_SetCameraPositionAndTarget_UpVecY( VECTOR  Position, VECTOR  Target);
		public static int  SetCameraPositionAndTarget_UpVecY( VECTOR  Position, VECTOR  Target)
		{
			return dx_SetCameraPositionAndTarget_UpVecY( Position , Target );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraPositionAndTargetAndUpVec")]
		extern static int  dx_SetCameraPositionAndTargetAndUpVec( VECTOR  Position, VECTOR  Target, VECTOR  Up);
		public static int  SetCameraPositionAndTargetAndUpVec( VECTOR  Position, VECTOR  Target, VECTOR  Up)
		{
			return dx_SetCameraPositionAndTargetAndUpVec( Position , Target , Up );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraPositionAndAngle")]
		extern static int  dx_SetCameraPositionAndAngle( VECTOR  Position, float  VRotate, float  HRotate, float  TRotate);
		public static int  SetCameraPositionAndAngle( VECTOR  Position, float  VRotate, float  HRotate, float  TRotate)
		{
			return dx_SetCameraPositionAndAngle( Position , VRotate , HRotate , TRotate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraViewMatrix")]
		extern static int  dx_SetCameraViewMatrix( MATRIX  ViewMatrix);
		public static int  SetCameraViewMatrix( MATRIX  ViewMatrix)
		{
			return dx_SetCameraViewMatrix( ViewMatrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraScreenCenter")]
		extern static int  dx_SetCameraScreenCenter( float  x, float  y);
		public static int  SetCameraScreenCenter( float  x, float  y)
		{
			return dx_SetCameraScreenCenter( x , y );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupCamera_Perspective")]
		extern static int  dx_SetupCamera_Perspective( float  Fov);
		public static int  SetupCamera_Perspective( float  Fov)
		{
			return dx_SetupCamera_Perspective( Fov );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupCamera_Ortho")]
		extern static int  dx_SetupCamera_Ortho( float  Size);
		public static int  SetupCamera_Ortho( float  Size)
		{
			return dx_SetupCamera_Ortho( Size );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupCamera_ProjectionMatrix")]
		extern static int  dx_SetupCamera_ProjectionMatrix( MATRIX  ProjectionMatrix);
		public static int  SetupCamera_ProjectionMatrix( MATRIX  ProjectionMatrix)
		{
			return dx_SetupCamera_ProjectionMatrix( ProjectionMatrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraDotAspect")]
		extern static int  dx_SetCameraDotAspect( float  DotAspect);
		public static int  SetCameraDotAspect( float  DotAspect)
		{
			return dx_SetCameraDotAspect( DotAspect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraNear")]
		extern static float  dx_GetCameraNear( );
		public static float  GetCameraNear( )
		{
			return dx_GetCameraNear( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraFar")]
		extern static float  dx_GetCameraFar( );
		public static float  GetCameraFar( )
		{
			return dx_GetCameraFar( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraPosition")]
		extern static VECTOR  dx_GetCameraPosition( );
		public static VECTOR  GetCameraPosition( )
		{
			return dx_GetCameraPosition( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraTarget")]
		extern static VECTOR  dx_GetCameraTarget( );
		public static VECTOR  GetCameraTarget( )
		{
			return dx_GetCameraTarget( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraUpVector")]
		extern static VECTOR  dx_GetCameraUpVector( );
		public static VECTOR  GetCameraUpVector( )
		{
			return dx_GetCameraUpVector( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraAngleHRotate")]
		extern static float  dx_GetCameraAngleHRotate( );
		public static float  GetCameraAngleHRotate( )
		{
			return dx_GetCameraAngleHRotate( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraAngleVRotate")]
		extern static float  dx_GetCameraAngleVRotate( );
		public static float  GetCameraAngleVRotate( )
		{
			return dx_GetCameraAngleVRotate( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraAngleTRotate")]
		extern static float  dx_GetCameraAngleTRotate( );
		public static float  GetCameraAngleTRotate( )
		{
			return dx_GetCameraAngleTRotate( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraViewMatrix")]
		extern static MATRIX  dx_GetCameraViewMatrix( );
		public static MATRIX  GetCameraViewMatrix( )
		{
			return dx_GetCameraViewMatrix( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraBillboardMatrix")]
		extern static MATRIX  dx_GetCameraBillboardMatrix( );
		public static MATRIX  GetCameraBillboardMatrix( )
		{
			return dx_GetCameraBillboardMatrix( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraFov")]
		extern static float  dx_GetCameraFov( );
		public static float  GetCameraFov( )
		{
			return dx_GetCameraFov( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraSize")]
		extern static float  dx_GetCameraSize( );
		public static float  GetCameraSize( )
		{
			return dx_GetCameraSize( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraProjectionMatrix")]
		extern static MATRIX  dx_GetCameraProjectionMatrix( );
		public static MATRIX  GetCameraProjectionMatrix( )
		{
			return dx_GetCameraProjectionMatrix( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraDotAspect")]
		extern static float  dx_GetCameraDotAspect( );
		public static float  GetCameraDotAspect( )
		{
			return dx_GetCameraDotAspect( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseLighting")]
		extern static int  dx_SetUseLighting( int  Flag);
		public static int  SetUseLighting( int  Flag)
		{
			return dx_SetUseLighting( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaterialUseVertDifColor")]
		extern static int  dx_SetMaterialUseVertDifColor( int  UseFlag);
		public static int  SetMaterialUseVertDifColor( int  UseFlag)
		{
			return dx_SetMaterialUseVertDifColor( UseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaterialUseVertSpcColor")]
		extern static int  dx_SetMaterialUseVertSpcColor( int  UseFlag);
		public static int  SetMaterialUseVertSpcColor( int  UseFlag)
		{
			return dx_SetMaterialUseVertSpcColor( UseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaterialParam")]
		extern static int  dx_SetMaterialParam( MATERIALPARAM  Material);
		public static int  SetMaterialParam( MATERIALPARAM  Material)
		{
			return dx_SetMaterialParam( Material );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseSpecular")]
		extern static int  dx_SetUseSpecular( int  UseFlag);
		public static int  SetUseSpecular( int  UseFlag)
		{
			return dx_SetUseSpecular( UseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGlobalAmbientLight")]
		extern static int  dx_SetGlobalAmbientLight( COLOR_F  Color);
		public static int  SetGlobalAmbientLight( COLOR_F  Color)
		{
			return dx_SetGlobalAmbientLight( Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeLightTypeDir")]
		extern static int  dx_ChangeLightTypeDir( VECTOR  Direction);
		public static int  ChangeLightTypeDir( VECTOR  Direction)
		{
			return dx_ChangeLightTypeDir( Direction );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeLightTypeSpot")]
		extern static int  dx_ChangeLightTypeSpot( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  ChangeLightTypeSpot( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			return dx_ChangeLightTypeSpot( Position , Direction , OutAngle , InAngle , Range , Atten0 , Atten1 , Atten2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeLightTypePoint")]
		extern static int  dx_ChangeLightTypePoint( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  ChangeLightTypePoint( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			return dx_ChangeLightTypePoint( Position , Range , Atten0 , Atten1 , Atten2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightEnable")]
		extern static int  dx_SetLightEnable( int  EnableFlag);
		public static int  SetLightEnable( int  EnableFlag)
		{
			return dx_SetLightEnable( EnableFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightDifColor")]
		extern static int  dx_SetLightDifColor( COLOR_F  Color);
		public static int  SetLightDifColor( COLOR_F  Color)
		{
			return dx_SetLightDifColor( Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightSpcColor")]
		extern static int  dx_SetLightSpcColor( COLOR_F  Color);
		public static int  SetLightSpcColor( COLOR_F  Color)
		{
			return dx_SetLightSpcColor( Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightAmbColor")]
		extern static int  dx_SetLightAmbColor( COLOR_F  Color);
		public static int  SetLightAmbColor( COLOR_F  Color)
		{
			return dx_SetLightAmbColor( Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightDirection")]
		extern static int  dx_SetLightDirection( VECTOR  Direction);
		public static int  SetLightDirection( VECTOR  Direction)
		{
			return dx_SetLightDirection( Direction );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightPosition")]
		extern static int  dx_SetLightPosition( VECTOR  Position);
		public static int  SetLightPosition( VECTOR  Position)
		{
			return dx_SetLightPosition( Position );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightRangeAtten")]
		extern static int  dx_SetLightRangeAtten( float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  SetLightRangeAtten( float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			return dx_SetLightRangeAtten( Range , Atten0 , Atten1 , Atten2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightAngle")]
		extern static int  dx_SetLightAngle( float  OutAngle, float  InAngle);
		public static int  SetLightAngle( float  OutAngle, float  InAngle)
		{
			return dx_SetLightAngle( OutAngle , InAngle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightType")]
		extern static int  dx_GetLightType( );
		public static int  GetLightType( )
		{
			return dx_GetLightType( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightEnable")]
		extern static int  dx_GetLightEnable( );
		public static int  GetLightEnable( )
		{
			return dx_GetLightEnable( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightDifColor")]
		extern static COLOR_F  dx_GetLightDifColor( );
		public static COLOR_F  GetLightDifColor( )
		{
			return dx_GetLightDifColor( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightSpcColor")]
		extern static COLOR_F  dx_GetLightSpcColor( );
		public static COLOR_F  GetLightSpcColor( )
		{
			return dx_GetLightSpcColor( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightAmbColor")]
		extern static COLOR_F  dx_GetLightAmbColor( );
		public static COLOR_F  GetLightAmbColor( )
		{
			return dx_GetLightAmbColor( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightDirection")]
		extern static VECTOR  dx_GetLightDirection( );
		public static VECTOR  GetLightDirection( )
		{
			return dx_GetLightDirection( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightPosition")]
		extern static VECTOR  dx_GetLightPosition( );
		public static VECTOR  GetLightPosition( )
		{
			return dx_GetLightPosition( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightRangeAtten")]
		extern static int  dx_GetLightRangeAtten( out float  Range, out float  Atten0, out float  Atten1, out float  Atten2);
		public static int  GetLightRangeAtten( out float  Range, out float  Atten0, out float  Atten1, out float  Atten2)
		{
			return dx_GetLightRangeAtten( out Range , out Atten0 , out Atten1 , out Atten2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightAngle")]
		extern static int  dx_GetLightAngle( out float  OutAngle, out float  InAngle);
		public static int  GetLightAngle( out float  OutAngle, out float  InAngle)
		{
			return dx_GetLightAngle( out OutAngle , out InAngle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateDirLightHandle")]
		extern static int  dx_CreateDirLightHandle( VECTOR  Direction);
		public static int  CreateDirLightHandle( VECTOR  Direction)
		{
			return dx_CreateDirLightHandle( Direction );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateSpotLightHandle")]
		extern static int  dx_CreateSpotLightHandle( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  CreateSpotLightHandle( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			return dx_CreateSpotLightHandle( Position , Direction , OutAngle , InAngle , Range , Atten0 , Atten1 , Atten2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePointLightHandle")]
		extern static int  dx_CreatePointLightHandle( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  CreatePointLightHandle( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			return dx_CreatePointLightHandle( Position , Range , Atten0 , Atten1 , Atten2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteLightHandle")]
		extern static int  dx_DeleteLightHandle( int  LHandle);
		public static int  DeleteLightHandle( int  LHandle)
		{
			return dx_DeleteLightHandle( LHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteLightHandleAll")]
		extern static int  dx_DeleteLightHandleAll( );
		public static int  DeleteLightHandleAll( )
		{
			return dx_DeleteLightHandleAll( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightTypeHandle")]
		extern static int  dx_SetLightTypeHandle( int  LHandle, int  LightType);
		public static int  SetLightTypeHandle( int  LHandle, int  LightType)
		{
			return dx_SetLightTypeHandle( LHandle , LightType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightEnableHandle")]
		extern static int  dx_SetLightEnableHandle( int  LHandle, int  EnableFlag);
		public static int  SetLightEnableHandle( int  LHandle, int  EnableFlag)
		{
			return dx_SetLightEnableHandle( LHandle , EnableFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightDifColorHandle")]
		extern static int  dx_SetLightDifColorHandle( int  LHandle, COLOR_F  Color);
		public static int  SetLightDifColorHandle( int  LHandle, COLOR_F  Color)
		{
			return dx_SetLightDifColorHandle( LHandle , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightSpcColorHandle")]
		extern static int  dx_SetLightSpcColorHandle( int  LHandle, COLOR_F  Color);
		public static int  SetLightSpcColorHandle( int  LHandle, COLOR_F  Color)
		{
			return dx_SetLightSpcColorHandle( LHandle , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightAmbColorHandle")]
		extern static int  dx_SetLightAmbColorHandle( int  LHandle, COLOR_F  Color);
		public static int  SetLightAmbColorHandle( int  LHandle, COLOR_F  Color)
		{
			return dx_SetLightAmbColorHandle( LHandle , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightDirectionHandle")]
		extern static int  dx_SetLightDirectionHandle( int  LHandle, VECTOR  Direction);
		public static int  SetLightDirectionHandle( int  LHandle, VECTOR  Direction)
		{
			return dx_SetLightDirectionHandle( LHandle , Direction );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightPositionHandle")]
		extern static int  dx_SetLightPositionHandle( int  LHandle, VECTOR  Position);
		public static int  SetLightPositionHandle( int  LHandle, VECTOR  Position)
		{
			return dx_SetLightPositionHandle( LHandle , Position );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightRangeAttenHandle")]
		extern static int  dx_SetLightRangeAttenHandle( int  LHandle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  SetLightRangeAttenHandle( int  LHandle, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			return dx_SetLightRangeAttenHandle( LHandle , Range , Atten0 , Atten1 , Atten2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightAngleHandle")]
		extern static int  dx_SetLightAngleHandle( int  LHandle, float  OutAngle, float  InAngle);
		public static int  SetLightAngleHandle( int  LHandle, float  OutAngle, float  InAngle)
		{
			return dx_SetLightAngleHandle( LHandle , OutAngle , InAngle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightTypeHandle")]
		extern static int  dx_GetLightTypeHandle( int  LHandle);
		public static int  GetLightTypeHandle( int  LHandle)
		{
			return dx_GetLightTypeHandle( LHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightEnableHandle")]
		extern static int  dx_GetLightEnableHandle( int  LHandle);
		public static int  GetLightEnableHandle( int  LHandle)
		{
			return dx_GetLightEnableHandle( LHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightDifColorHandle")]
		extern static COLOR_F  dx_GetLightDifColorHandle( int  LHandle);
		public static COLOR_F  GetLightDifColorHandle( int  LHandle)
		{
			return dx_GetLightDifColorHandle( LHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightSpcColorHandle")]
		extern static COLOR_F  dx_GetLightSpcColorHandle( int  LHandle);
		public static COLOR_F  GetLightSpcColorHandle( int  LHandle)
		{
			return dx_GetLightSpcColorHandle( LHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightAmbColorHandle")]
		extern static COLOR_F  dx_GetLightAmbColorHandle( int  LHandle);
		public static COLOR_F  GetLightAmbColorHandle( int  LHandle)
		{
			return dx_GetLightAmbColorHandle( LHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightDirectionHandle")]
		extern static VECTOR  dx_GetLightDirectionHandle( int  LHandle);
		public static VECTOR  GetLightDirectionHandle( int  LHandle)
		{
			return dx_GetLightDirectionHandle( LHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightPositionHandle")]
		extern static VECTOR  dx_GetLightPositionHandle( int  LHandle);
		public static VECTOR  GetLightPositionHandle( int  LHandle)
		{
			return dx_GetLightPositionHandle( LHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightRangeAttenHandle")]
		extern static int  dx_GetLightRangeAttenHandle( int  LHandle, out float  Range, out float  Atten0, out float  Atten1, out float  Atten2);
		public static int  GetLightRangeAttenHandle( int  LHandle, out float  Range, out float  Atten0, out float  Atten1, out float  Atten2)
		{
			return dx_GetLightRangeAttenHandle( LHandle , out Range , out Atten0 , out Atten1 , out Atten2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightAngleHandle")]
		extern static int  dx_GetLightAngleHandle( int  LHandle, out float  OutAngle, out float  InAngle);
		public static int  GetLightAngleHandle( int  LHandle, out float  OutAngle, out float  InAngle)
		{
			return dx_GetLightAngleHandle( LHandle , out OutAngle , out InAngle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphColorBitDepth")]
		extern static int  dx_SetGraphColorBitDepth( int  ColorBitDepth);
		public static int  SetGraphColorBitDepth( int  ColorBitDepth)
		{
			return dx_SetGraphColorBitDepth( ColorBitDepth );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCreateGraphColorBitDepth")]
		extern static int  dx_SetCreateGraphColorBitDepth( int  BitDepth);
		public static int  SetCreateGraphColorBitDepth( int  BitDepth)
		{
			return dx_SetCreateGraphColorBitDepth( BitDepth );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCreateGraphColorBitDepth")]
		extern static int  dx_GetCreateGraphColorBitDepth( );
		public static int  GetCreateGraphColorBitDepth( )
		{
			return dx_GetCreateGraphColorBitDepth( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphColorBitDepth")]
		extern static int  dx_GetGraphColorBitDepth( );
		public static int  GetGraphColorBitDepth( )
		{
			return dx_GetGraphColorBitDepth( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidGraphCreateFlag")]
		extern static int  dx_SetDrawValidGraphCreateFlag( int  Flag);
		public static int  SetDrawValidGraphCreateFlag( int  Flag)
		{
			return dx_SetDrawValidGraphCreateFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawValidGraphCreateFlag")]
		extern static int  dx_GetDrawValidGraphCreateFlag( );
		public static int  GetDrawValidGraphCreateFlag( )
		{
			return dx_GetDrawValidGraphCreateFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLeftUpColorIsTransColorFlag")]
		extern static int  dx_SetLeftUpColorIsTransColorFlag( int  Flag);
		public static int  SetLeftUpColorIsTransColorFlag( int  Flag)
		{
			return dx_SetLeftUpColorIsTransColorFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseBlendGraphCreateFlag")]
		extern static int  dx_GetUseBlendGraphCreateFlag( );
		public static int  GetUseBlendGraphCreateFlag( )
		{
			return dx_GetUseBlendGraphCreateFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseSystemMemGraphCreateFlag")]
		extern static int  dx_GetUseSystemMemGraphCreateFlag( );
		public static int  GetUseSystemMemGraphCreateFlag( )
		{
			return dx_GetUseSystemMemGraphCreateFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseBlendGraphCreateFlag")]
		extern static int  dx_SetUseBlendGraphCreateFlag( int  Flag);
		public static int  SetUseBlendGraphCreateFlag( int  Flag)
		{
			return dx_SetUseBlendGraphCreateFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseAlphaTestGraphCreateFlag")]
		extern static int  dx_SetUseAlphaTestGraphCreateFlag( int  Flag);
		public static int  SetUseAlphaTestGraphCreateFlag( int  Flag)
		{
			return dx_SetUseAlphaTestGraphCreateFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseAlphaTestFlag")]
		extern static int  dx_SetUseAlphaTestFlag( int  Flag);
		public static int  SetUseAlphaTestFlag( int  Flag)
		{
			return dx_SetUseAlphaTestFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseNoBlendModeParam")]
		extern static int  dx_SetUseNoBlendModeParam( int  Flag);
		public static int  SetUseNoBlendModeParam( int  Flag)
		{
			return dx_SetUseNoBlendModeParam( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidFlagOf3DGraph")]
		extern static int  dx_SetDrawValidFlagOf3DGraph( int  Flag);
		public static int  SetDrawValidFlagOf3DGraph( int  Flag)
		{
			return dx_SetDrawValidFlagOf3DGraph( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseAlphaTestFlag")]
		extern static int  dx_GetUseAlphaTestFlag( );
		public static int  GetUseAlphaTestFlag( )
		{
			return dx_GetUseAlphaTestFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseAlphaTestGraphCreateFlag")]
		extern static int  dx_GetUseAlphaTestGraphCreateFlag( );
		public static int  GetUseAlphaTestGraphCreateFlag( )
		{
			return dx_GetUseAlphaTestGraphCreateFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidAlphaChannelGraphCreateFlag")]
		extern static int  dx_SetDrawValidAlphaChannelGraphCreateFlag( int  Flag);
		public static int  SetDrawValidAlphaChannelGraphCreateFlag( int  Flag)
		{
			return dx_SetDrawValidAlphaChannelGraphCreateFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawValidAlphaChannelGraphCreateFlag")]
		extern static int  dx_GetDrawValidAlphaChannelGraphCreateFlag( );
		public static int  GetDrawValidAlphaChannelGraphCreateFlag( )
		{
			return dx_GetDrawValidAlphaChannelGraphCreateFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidFloatTypeGraphCreateFlag")]
		extern static int  dx_SetDrawValidFloatTypeGraphCreateFlag( int  Flag);
		public static int  SetDrawValidFloatTypeGraphCreateFlag( int  Flag)
		{
			return dx_SetDrawValidFloatTypeGraphCreateFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawValidFloatTypeGraphCreateFlag")]
		extern static int  dx_GetDrawValidFloatTypeGraphCreateFlag( );
		public static int  GetDrawValidFloatTypeGraphCreateFlag( )
		{
			return dx_GetDrawValidFloatTypeGraphCreateFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidMultiSample")]
		extern static int  dx_SetDrawValidMultiSample( int  Samples, int  Quality);
		public static int  SetDrawValidMultiSample( int  Samples, int  Quality)
		{
			return dx_SetDrawValidMultiSample( Samples , Quality );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseZBufferFlag")]
		extern static int  dx_SetUseZBufferFlag( int  Flag);
		public static int  SetUseZBufferFlag( int  Flag)
		{
			return dx_SetUseZBufferFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWriteZBufferFlag")]
		extern static int  dx_SetWriteZBufferFlag( int  Flag);
		public static int  SetWriteZBufferFlag( int  Flag)
		{
			return dx_SetWriteZBufferFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBufferCmpType")]
		extern static int  dx_SetZBufferCmpType( int  CmpType);
		public static int  SetZBufferCmpType( int  CmpType)
		{
			return dx_SetZBufferCmpType( CmpType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBias")]
		extern static int  dx_SetZBias( int  Bias);
		public static int  SetZBias( int  Bias)
		{
			return dx_SetZBias( Bias );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseZBuffer3D")]
		extern static int  dx_SetUseZBuffer3D( int  Flag);
		public static int  SetUseZBuffer3D( int  Flag)
		{
			return dx_SetUseZBuffer3D( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWriteZBuffer3D")]
		extern static int  dx_SetWriteZBuffer3D( int  Flag);
		public static int  SetWriteZBuffer3D( int  Flag)
		{
			return dx_SetWriteZBuffer3D( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBufferCmpType3D")]
		extern static int  dx_SetZBufferCmpType3D( int  CmpType);
		public static int  SetZBufferCmpType3D( int  CmpType)
		{
			return dx_SetZBufferCmpType3D( CmpType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBias3D")]
		extern static int  dx_SetZBias3D( int  Bias);
		public static int  SetZBias3D( int  Bias)
		{
			return dx_SetZBias3D( Bias );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawZ")]
		extern static int  dx_SetDrawZ( float  Z);
		public static int  SetDrawZ( float  Z)
		{
			return dx_SetDrawZ( Z );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseTransColor")]
		extern static int  dx_SetUseTransColor( int  Flag);
		public static int  SetUseTransColor( int  Flag)
		{
			return dx_SetUseTransColor( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseTransColorGraphCreateFlag")]
		extern static int  dx_SetUseTransColorGraphCreateFlag( int  Flag);
		public static int  SetUseTransColorGraphCreateFlag( int  Flag)
		{
			return dx_SetUseTransColorGraphCreateFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseAlphaChannelGraphCreateFlag")]
		extern static int  dx_SetUseAlphaChannelGraphCreateFlag( int  Flag);
		public static int  SetUseAlphaChannelGraphCreateFlag( int  Flag)
		{
			return dx_SetUseAlphaChannelGraphCreateFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseGraphAlphaChannel")]
		extern static int  dx_SetUseGraphAlphaChannel( int  Flag);
		public static int  SetUseGraphAlphaChannel( int  Flag)
		{
			return dx_SetUseGraphAlphaChannel( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseAlphaChannelGraphCreateFlag")]
		extern static int  dx_GetUseAlphaChannelGraphCreateFlag( );
		public static int  GetUseAlphaChannelGraphCreateFlag( )
		{
			return dx_GetUseAlphaChannelGraphCreateFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseGraphAlphaChannel")]
		extern static int  dx_GetUseGraphAlphaChannel( );
		public static int  GetUseGraphAlphaChannel( )
		{
			return dx_GetUseGraphAlphaChannel( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseNotManageTextureFlag")]
		extern static int  dx_SetUseNotManageTextureFlag( int  Flag);
		public static int  SetUseNotManageTextureFlag( int  Flag)
		{
			return dx_SetUseNotManageTextureFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransColor")]
		extern static int  dx_SetTransColor( int  Red, int  Green, int  Blue);
		public static int  SetTransColor( int  Red, int  Green, int  Blue)
		{
			return dx_SetTransColor( Red , Green , Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransColor")]
		extern static int  dx_GetTransColor( out int  Red, out int  Green, out int  Blue);
		public static int  GetTransColor( out int  Red, out int  Green, out int  Blue)
		{
			return dx_GetTransColor( out Red , out Green , out Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawArea")]
		extern static int  dx_GetDrawArea( out RECT  Rect);
		public static int  GetDrawArea( out RECT  Rect)
		{
			return dx_GetDrawArea( out Rect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseNotManageTextureFlag")]
		extern static int  dx_GetUseNotManageTextureFlag( );
		public static int  GetUseNotManageTextureFlag( )
		{
			return dx_GetUseNotManageTextureFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseBasicGraphDraw3DDeviceMethodFlag")]
		extern static int  dx_SetUseBasicGraphDraw3DDeviceMethodFlag( int  Flag);
		public static int  SetUseBasicGraphDraw3DDeviceMethodFlag( int  Flag)
		{
			return dx_SetUseBasicGraphDraw3DDeviceMethodFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowDrawRect")]
		extern static int  dx_SetWindowDrawRect( out RECT  DrawRect);
		public static int  SetWindowDrawRect( out RECT  DrawRect)
		{
			return dx_SetWindowDrawRect( out DrawRect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawBlendMode")]
		extern static int  dx_GetDrawBlendMode( out int  BlendMode, out int  BlendParam);
		public static int  GetDrawBlendMode( out int  BlendMode, out int  BlendParam)
		{
			return dx_GetDrawBlendMode( out BlendMode , out BlendParam );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawMode")]
		extern static int  dx_GetDrawMode( );
		public static int  GetDrawMode( )
		{
			return dx_GetDrawMode( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawBright")]
		extern static int  dx_GetDrawBright( out int  Red, out int  Green, out int  Blue);
		public static int  GetDrawBright( out int  Red, out int  Green, out int  Blue)
		{
			return dx_GetDrawBright( out Red , out Green , out Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetActiveGraph")]
		extern static int  dx_GetActiveGraph( );
		public static int  GetActiveGraph( )
		{
			return dx_GetActiveGraph( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTexFormatIndex")]
		extern static int  dx_GetTexFormatIndex( out IMAGEFORMATDESC  Format);
		public static int  GetTexFormatIndex( out IMAGEFORMATDESC  Format)
		{
			return dx_GetTexFormatIndex( out Format );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWaitVSyncFlag")]
		extern static int  dx_SetWaitVSyncFlag( int  Flag);
		public static int  SetWaitVSyncFlag( int  Flag)
		{
			return dx_SetWaitVSyncFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWaitVSyncFlag")]
		extern static int  dx_GetWaitVSyncFlag( );
		public static int  GetWaitVSyncFlag( )
		{
			return dx_GetWaitVSyncFlag( );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_ColorKaiseki")]
		extern unsafe static int  dx_ColorKaiseki( void *  PixelData, COLORDATA *  ColorData);
		public unsafe static int  ColorKaiseki( void *  PixelData, COLORDATA *  ColorData)
		{
			return dx_ColorKaiseki( PixelData , ColorData );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_SetDefTransformMatrix")]
		extern static int  dx_SetDefTransformMatrix( );
		public static int  SetDefTransformMatrix( )
		{
			return dx_SetDefTransformMatrix( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetEmulation320x240")]
		extern static int  dx_SetEmulation320x240( int  Flag);
		public static int  SetEmulation320x240( int  Flag)
		{
			return dx_SetEmulation320x240( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseGraphBaseDataBackup")]
		extern static int  dx_SetUseGraphBaseDataBackup( int  Flag);
		public static int  SetUseGraphBaseDataBackup( int  Flag)
		{
			return dx_SetUseGraphBaseDataBackup( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseGraphBaseDataBackup")]
		extern static int  dx_GetUseGraphBaseDataBackup( );
		public static int  GetUseGraphBaseDataBackup( )
		{
			return dx_GetUseGraphBaseDataBackup( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateMaskScreen")]
		extern static int  dx_CreateMaskScreen( );
		public static int  CreateMaskScreen( )
		{
			return dx_CreateMaskScreen( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMaskScreen")]
		extern static int  dx_DeleteMaskScreen( );
		public static int  DeleteMaskScreen( )
		{
			return dx_DeleteMaskScreen( );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetMaskSurface")]
		extern unsafe static void *  dx_GetMaskSurface( );
		public unsafe static void *  GetMaskSurface( )
		{
			return dx_GetMaskSurface( );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DrawMaskToDirectData")]
		extern unsafe static int  dx_DrawMaskToDirectData( int  x, int  y, int  Width, int  Height, void *  MaskData, int  TransMode);
		public unsafe static int  DrawMaskToDirectData( int  x, int  y, int  Width, int  Height, void *  MaskData, int  TransMode)
		{
			return dx_DrawMaskToDirectData( x , y , Width , Height , MaskData , TransMode );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DrawFillMaskToDirectData")]
		extern unsafe static int  dx_DrawFillMaskToDirectData( int  x1, int  y1, int  x2, int  y2, int  Width, int  Height, void *  MaskData);
		public unsafe static int  DrawFillMaskToDirectData( int  x1, int  y1, int  x2, int  y2, int  Width, int  Height, void *  MaskData)
		{
			return dx_DrawFillMaskToDirectData( x1 , y1 , x2 , y2 , Width , Height , MaskData );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseMaskScreenFlag")]
		extern static int  dx_SetUseMaskScreenFlag( int  ValidFlag);
		public static int  SetUseMaskScreenFlag( int  ValidFlag)
		{
			return dx_SetUseMaskScreenFlag( ValidFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseMaskScreenFlag")]
		extern static int  dx_GetUseMaskScreenFlag( );
		public static int  GetUseMaskScreenFlag( )
		{
			return dx_GetUseMaskScreenFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FillMaskScreen")]
		extern static int  dx_FillMaskScreen( int  Flag);
		public static int  FillMaskScreen( int  Flag)
		{
			return dx_FillMaskScreen( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitMask")]
		extern static int  dx_InitMask( );
		public static int  InitMask( )
		{
			return dx_InitMask( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeMask")]
		extern static int  dx_MakeMask( int  Width, int  Height);
		public static int  MakeMask( int  Width, int  Height)
		{
			return dx_MakeMask( Width , Height );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMaskSize")]
		extern static int  dx_GetMaskSize( out int  WidthBuf, out int  HeightBuf, int  MaskHandle);
		public static int  GetMaskSize( out int  WidthBuf, out int  HeightBuf, int  MaskHandle)
		{
			return dx_GetMaskSize( out WidthBuf , out HeightBuf , MaskHandle );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_SetDataToMask")]
		extern unsafe static int  dx_SetDataToMask( int  Width, int  Height, void *  MaskData, int  MaskHandle);
		public unsafe static int  SetDataToMask( int  Width, int  Height, void *  MaskData, int  MaskHandle)
		{
			return dx_SetDataToMask( Width , Height , MaskData , MaskHandle );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMask")]
		extern static int  dx_DeleteMask( int  MaskHandle);
		public static int  DeleteMask( int  MaskHandle)
		{
			return dx_DeleteMask( MaskHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadMask")]
		extern static int  dx_LoadMask( string  FileName);
		public static int  LoadMask( string  FileName)
		{
			return dx_LoadMask( FileName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivMask")]
		extern static int  dx_LoadDivMask( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		public static int  LoadDivMask( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			return dx_LoadDivMask( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawMask")]
		extern static int  dx_DrawMask( int  x, int  y, int  MaskHandle, int  TransMode);
		public static int  DrawMask( int  x, int  y, int  MaskHandle, int  TransMode)
		{
			return dx_DrawMask( x , y , MaskHandle , TransMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringMask")]
		extern static int  dx_DrawStringMask( int  x, int  y, int  Flag, string  String);
		public static int  DrawStringMask( int  x, int  y, int  Flag, string  String)
		{
			return dx_DrawStringMask( x , y , Flag , String );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringMaskToHandle")]
		extern static int  dx_DrawStringMaskToHandle( int  x, int  y, int  Flag, int  FontHandle, string  String);
		public static int  DrawStringMaskToHandle( int  x, int  y, int  Flag, int  FontHandle, string  String)
		{
			return dx_DrawStringMaskToHandle( x , y , Flag , FontHandle , String );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawFillMask")]
		extern static int  dx_DrawFillMask( int  x1, int  y1, int  x2, int  y2, int  MaskHandle);
		public static int  DrawFillMask( int  x1, int  y1, int  x2, int  y2, int  MaskHandle)
		{
			return dx_DrawFillMask( x1 , y1 , x2 , y2 , MaskHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaskTransColor")]
		extern static int  dx_SetMaskTransColor( int  ColorCode);
		public static int  SetMaskTransColor( int  ColorCode)
		{
			return dx_SetMaskTransColor( ColorCode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaskReverseEffectFlag")]
		extern static int  dx_SetMaskReverseEffectFlag( int  ReverseFlag);
		public static int  SetMaskReverseEffectFlag( int  ReverseFlag)
		{
			return dx_SetMaskReverseEffectFlag( ReverseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMaskScreenData")]
		extern static int  dx_GetMaskScreenData( int  x1, int  y1, int  x2, int  y2, int  MaskHandle);
		public static int  GetMaskScreenData( int  x1, int  y1, int  x2, int  y2, int  MaskHandle)
		{
			return dx_GetMaskScreenData( x1 , y1 , x2 , y2 , MaskHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMaskUseFlag")]
		extern static int  dx_GetMaskUseFlag( );
		public static int  GetMaskUseFlag( )
		{
			return dx_GetMaskUseFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMovieRightImageAlphaFlag")]
		extern static int  dx_SetMovieRightImageAlphaFlag( int  Flag);
		public static int  SetMovieRightImageAlphaFlag( int  Flag)
		{
			return dx_SetMovieRightImageAlphaFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_EnumFontName")]
		extern static int  dx_EnumFontName( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  JapanOnlyFlag);
		public static int  EnumFontName( System.Text.StringBuilder  NameBuffer, int  NameBufferNum)
		{
			return dx_EnumFontName( NameBuffer , NameBufferNum , TRUE );
		}
		public static int  EnumFontName( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  JapanOnlyFlag)
		{
			return dx_EnumFontName( NameBuffer , NameBufferNum , JapanOnlyFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_EnumFontNameEx")]
		extern static int  dx_EnumFontNameEx( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  CharSet);
		public static int  EnumFontNameEx( System.Text.StringBuilder  NameBuffer, int  NameBufferNum)
		{
			return dx_EnumFontNameEx( NameBuffer , NameBufferNum , -1 );
		}
		public static int  EnumFontNameEx( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  CharSet)
		{
			return dx_EnumFontNameEx( NameBuffer , NameBufferNum , CharSet );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitFontToHandle")]
		extern static int  dx_InitFontToHandle( );
		public static int  InitFontToHandle( )
		{
			return dx_InitFontToHandle( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateFontToHandle")]
		extern static int  dx_CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  DataIndex, int  ID);
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick)
		{
			return dx_CreateFontToHandle( FontName , Size , Thick , -1 , -1 , -1 , FALSE , -1 , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType)
		{
			return dx_CreateFontToHandle( FontName , Size , Thick , FontType , -1 , -1 , FALSE , -1 , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet)
		{
			return dx_CreateFontToHandle( FontName , Size , Thick , FontType , CharSet , -1 , FALSE , -1 , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize)
		{
			return dx_CreateFontToHandle( FontName , Size , Thick , FontType , CharSet , EdgeSize , FALSE , -1 , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic)
		{
			return dx_CreateFontToHandle( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic , -1 , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  DataIndex)
		{
			return dx_CreateFontToHandle( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic , DataIndex , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  DataIndex, int  ID)
		{
			return dx_CreateFontToHandle( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic , DataIndex , ID );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontSpaceToHandle")]
		extern static int  dx_SetFontSpaceToHandle( int  Point, int  FontHandle);
		public static int  SetFontSpaceToHandle( int  Point, int  FontHandle)
		{
			return dx_SetFontSpaceToHandle( Point , FontHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDefaultFontState")]
		extern static int  dx_SetDefaultFontState( string  FontName, int  Size, int  Thick);
		public static int  SetDefaultFontState( string  FontName, int  Size, int  Thick)
		{
			return dx_SetDefaultFontState( FontName , Size , Thick );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteFontToHandle")]
		extern static int  dx_DeleteFontToHandle( int  FontHandle);
		public static int  DeleteFontToHandle( int  FontHandle)
		{
			return dx_DeleteFontToHandle( FontHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontLostFlag")]
		extern static int  dx_SetFontLostFlag( int  FontHandle, out int  LostFlag);
		public static int  SetFontLostFlag( int  FontHandle, out int  LostFlag)
		{
			return dx_SetFontLostFlag( FontHandle , out LostFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontSize")]
		extern static int  dx_SetFontSize( int  FontSize);
		public static int  SetFontSize( int  FontSize)
		{
			return dx_SetFontSize( FontSize );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontThickness")]
		extern static int  dx_SetFontThickness( int  ThickPal);
		public static int  SetFontThickness( int  ThickPal)
		{
			return dx_SetFontThickness( ThickPal );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontSpace")]
		extern static int  dx_SetFontSpace( int  Point);
		public static int  SetFontSpace( int  Point)
		{
			return dx_SetFontSpace( Point );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontCacheToTextureFlag")]
		extern static int  dx_SetFontCacheToTextureFlag( int  Flag);
		public static int  SetFontCacheToTextureFlag( int  Flag)
		{
			return dx_SetFontCacheToTextureFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontChacheToTextureFlag")]
		extern static int  dx_SetFontChacheToTextureFlag( int  Flag);
		public static int  SetFontChacheToTextureFlag( int  Flag)
		{
			return dx_SetFontChacheToTextureFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontCacheCharNum")]
		extern static int  dx_SetFontCacheCharNum( int  CharNum);
		public static int  SetFontCacheCharNum( int  CharNum)
		{
			return dx_SetFontCacheCharNum( CharNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeFont")]
		extern static int  dx_ChangeFont( string  FontName, int  CharSet);
		public static int  ChangeFont( string  FontName)
		{
			return dx_ChangeFont( FontName , -1 );
		}
		public static int  ChangeFont( string  FontName, int  CharSet)
		{
			return dx_ChangeFont( FontName , CharSet );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeFontType")]
		extern static int  dx_ChangeFontType( int  FontType);
		public static int  ChangeFontType( int  FontType)
		{
			return dx_ChangeFontType( FontType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontMaxWidth")]
		extern static int  dx_GetFontMaxWidth( );
		public static int  GetFontMaxWidth( )
		{
			return dx_GetFontMaxWidth( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontMaxWidthToHandle")]
		extern static int  dx_GetFontMaxWidthToHandle( int  FontHandle);
		public static int  GetFontMaxWidthToHandle( int  FontHandle)
		{
			return dx_GetFontMaxWidthToHandle( FontHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontCharInfo")]
		extern static int  dx_GetFontCharInfo( int  FontHandle, string  Char, out int  DrawX, out int  DrawY, out int  NextCharX, out int  SizeX, out int  SizeY);
		public static int  GetFontCharInfo( int  FontHandle, string  Char, out int  DrawX, out int  DrawY, out int  NextCharX, out int  SizeX, out int  SizeY)
		{
			return dx_GetFontCharInfo( FontHandle , Char , out DrawX , out DrawY , out NextCharX , out SizeX , out SizeY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawStringWidth")]
		extern static int  dx_GetDrawStringWidth( string  String, int  StrLen, int  VerticalFlag);
		public static int  GetDrawStringWidth( string  String, int  StrLen)
		{
			return dx_GetDrawStringWidth( String , StrLen , FALSE );
		}
		public static int  GetDrawStringWidth( string  String, int  StrLen, int  VerticalFlag)
		{
			return dx_GetDrawStringWidth( String , StrLen , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawStringWidthToHandle")]
		extern static int  dx_GetDrawStringWidthToHandle( string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawStringWidthToHandle( string  String, int  StrLen, int  FontHandle)
		{
			return dx_GetDrawStringWidthToHandle( String , StrLen , FontHandle , FALSE );
		}
		public static int  GetDrawStringWidthToHandle( string  String, int  StrLen, int  FontHandle, int  VerticalFlag)
		{
			return dx_GetDrawStringWidthToHandle( String , StrLen , FontHandle , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawExtendStringWidth")]
		extern static int  dx_GetDrawExtendStringWidth( double  ExRateX, string  String, int  StrLen, int  VerticalFlag);
		public static int  GetDrawExtendStringWidth( double  ExRateX, string  String, int  StrLen)
		{
			return dx_GetDrawExtendStringWidth( ExRateX , String , StrLen , FALSE );
		}
		public static int  GetDrawExtendStringWidth( double  ExRateX, string  String, int  StrLen, int  VerticalFlag)
		{
			return dx_GetDrawExtendStringWidth( ExRateX , String , StrLen , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawExtendStringWidthToHandle")]
		extern static int  dx_GetDrawExtendStringWidthToHandle( double  ExRateX, string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawExtendStringWidthToHandle( double  ExRateX, string  String, int  StrLen, int  FontHandle)
		{
			return dx_GetDrawExtendStringWidthToHandle( ExRateX , String , StrLen , FontHandle , FALSE );
		}
		public static int  GetDrawExtendStringWidthToHandle( double  ExRateX, string  String, int  StrLen, int  FontHandle, int  VerticalFlag)
		{
			return dx_GetDrawExtendStringWidthToHandle( ExRateX , String , StrLen , FontHandle , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontStateToHandle")]
		extern static int  dx_GetFontStateToHandle( System.Text.StringBuilder  FontName, out int  Size, out int  Thick, int  FontHandle);
		public static int  GetFontStateToHandle( System.Text.StringBuilder  FontName, out int  Size, out int  Thick, int  FontHandle)
		{
			return dx_GetFontStateToHandle( FontName , out Size , out Thick , FontHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDefaultFontHandle")]
		extern static int  dx_GetDefaultFontHandle( );
		public static int  GetDefaultFontHandle( )
		{
			return dx_GetDefaultFontHandle( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontChacheToTextureFlag")]
		extern static int  dx_GetFontChacheToTextureFlag( );
		public static int  GetFontChacheToTextureFlag( )
		{
			return dx_GetFontChacheToTextureFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontCacheToTextureFlag")]
		extern static int  dx_GetFontCacheToTextureFlag( );
		public static int  GetFontCacheToTextureFlag( )
		{
			return dx_GetFontCacheToTextureFlag( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckFontChacheToTextureFlag")]
		extern static int  dx_CheckFontChacheToTextureFlag( int  FontHandle);
		public static int  CheckFontChacheToTextureFlag( int  FontHandle)
		{
			return dx_CheckFontChacheToTextureFlag( FontHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckFontCacheToTextureFlag")]
		extern static int  dx_CheckFontCacheToTextureFlag( int  FontHandle);
		public static int  CheckFontCacheToTextureFlag( int  FontHandle)
		{
			return dx_CheckFontCacheToTextureFlag( FontHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckFontHandleValid")]
		extern static int  dx_CheckFontHandleValid( int  FontHandle);
		public static int  CheckFontHandleValid( int  FontHandle)
		{
			return dx_CheckFontHandleValid( FontHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MultiByteCharCheck")]
		extern static int  dx_MultiByteCharCheck( string  Buf, int  CharSet);
		public static int  MultiByteCharCheck( string  Buf, int  CharSet)
		{
			return dx_MultiByteCharCheck( Buf , CharSet );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontCacheCharNum")]
		extern static int  dx_GetFontCacheCharNum( );
		public static int  GetFontCacheCharNum( )
		{
			return dx_GetFontCacheCharNum( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontSize")]
		extern static int  dx_GetFontSize( );
		public static int  GetFontSize( )
		{
			return dx_GetFontSize( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontSizeToHandle")]
		extern static int  dx_GetFontSizeToHandle( int  FontHandle);
		public static int  GetFontSizeToHandle( int  FontHandle)
		{
			return dx_GetFontSizeToHandle( FontHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateIdentityMatrix")]
		extern static int  dx_CreateIdentityMatrix( out MATRIX  Out);
		public static int  CreateIdentityMatrix( out MATRIX  Out)
		{
			return dx_CreateIdentityMatrix( out Out );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateLookAtMatrix")]
		extern static int  dx_CreateLookAtMatrix( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up);
		public static int  CreateLookAtMatrix( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up)
		{
			return dx_CreateLookAtMatrix( out Out , out Eye , out At , out Up );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateLookAtMatrix2")]
		extern static int  dx_CreateLookAtMatrix2( out MATRIX  Out, out VECTOR  Eye, double  XZAngle, double  Oira);
		public static int  CreateLookAtMatrix2( out MATRIX  Out, out VECTOR  Eye, double  XZAngle, double  Oira)
		{
			return dx_CreateLookAtMatrix2( out Out , out Eye , XZAngle , Oira );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateLookAtMatrixRH")]
		extern static int  dx_CreateLookAtMatrixRH( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up);
		public static int  CreateLookAtMatrixRH( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up)
		{
			return dx_CreateLookAtMatrixRH( out Out , out Eye , out At , out Up );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateMultiplyMatrix")]
		extern static int  dx_CreateMultiplyMatrix( out MATRIX  Out, out MATRIX  In1, out MATRIX  In2);
		public static int  CreateMultiplyMatrix( out MATRIX  Out, out MATRIX  In1, out MATRIX  In2)
		{
			return dx_CreateMultiplyMatrix( out Out , out In1 , out In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePerspectiveFovMatrix")]
		extern static int  dx_CreatePerspectiveFovMatrix( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect);
		public static int  CreatePerspectiveFovMatrix( out MATRIX  Out, float  fov, float  zn, float  zf)
		{
			return dx_CreatePerspectiveFovMatrix( out Out , fov , zn , zf , -1.0f );
		}
		public static int  CreatePerspectiveFovMatrix( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect)
		{
			return dx_CreatePerspectiveFovMatrix( out Out , fov , zn , zf , aspect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePerspectiveFovMatrixRH")]
		extern static int  dx_CreatePerspectiveFovMatrixRH( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect);
		public static int  CreatePerspectiveFovMatrixRH( out MATRIX  Out, float  fov, float  zn, float  zf)
		{
			return dx_CreatePerspectiveFovMatrixRH( out Out , fov , zn , zf , -1.0f );
		}
		public static int  CreatePerspectiveFovMatrixRH( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect)
		{
			return dx_CreatePerspectiveFovMatrixRH( out Out , fov , zn , zf , aspect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateOrthoMatrix")]
		extern static int  dx_CreateOrthoMatrix( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect);
		public static int  CreateOrthoMatrix( out MATRIX  Out, float  size, float  zn, float  zf)
		{
			return dx_CreateOrthoMatrix( out Out , size , zn , zf , -1.0f );
		}
		public static int  CreateOrthoMatrix( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect)
		{
			return dx_CreateOrthoMatrix( out Out , size , zn , zf , aspect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateOrthoMatrixRH")]
		extern static int  dx_CreateOrthoMatrixRH( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect);
		public static int  CreateOrthoMatrixRH( out MATRIX  Out, float  size, float  zn, float  zf)
		{
			return dx_CreateOrthoMatrixRH( out Out , size , zn , zf , -1.0f );
		}
		public static int  CreateOrthoMatrixRH( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect)
		{
			return dx_CreateOrthoMatrixRH( out Out , size , zn , zf , aspect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateScalingMatrix")]
		extern static int  dx_CreateScalingMatrix( out MATRIX  Out, float  sx, float  sy, float  sz);
		public static int  CreateScalingMatrix( out MATRIX  Out, float  sx, float  sy, float  sz)
		{
			return dx_CreateScalingMatrix( out Out , sx , sy , sz );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationXMatrix")]
		extern static int  dx_CreateRotationXMatrix( out MATRIX  Out, float  Angle);
		public static int  CreateRotationXMatrix( out MATRIX  Out, float  Angle)
		{
			return dx_CreateRotationXMatrix( out Out , Angle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationYMatrix")]
		extern static int  dx_CreateRotationYMatrix( out MATRIX  Out, float  Angle);
		public static int  CreateRotationYMatrix( out MATRIX  Out, float  Angle)
		{
			return dx_CreateRotationYMatrix( out Out , Angle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationZMatrix")]
		extern static int  dx_CreateRotationZMatrix( out MATRIX  Out, float  Angle);
		public static int  CreateRotationZMatrix( out MATRIX  Out, float  Angle)
		{
			return dx_CreateRotationZMatrix( out Out , Angle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateTranslationMatrix")]
		extern static int  dx_CreateTranslationMatrix( out MATRIX  Out, float  x, float  y, float  z);
		public static int  CreateTranslationMatrix( out MATRIX  Out, float  x, float  y, float  z)
		{
			return dx_CreateTranslationMatrix( out Out , x , y , z );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateTransposeMatrix")]
		extern static int  dx_CreateTransposeMatrix( out MATRIX  Out, out MATRIX  In);
		public static int  CreateTransposeMatrix( out MATRIX  Out, out MATRIX  In)
		{
			return dx_CreateTransposeMatrix( out Out , out In );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateInverseMatrix")]
		extern static int  dx_CreateInverseMatrix( out MATRIX  Out, out MATRIX  In);
		public static int  CreateInverseMatrix( out MATRIX  Out, out MATRIX  In)
		{
			return dx_CreateInverseMatrix( out Out , out In );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateViewportMatrix")]
		extern static int  dx_CreateViewportMatrix( out MATRIX  Out, float  CenterX, float  CenterY, float  Width, float  Height);
		public static int  CreateViewportMatrix( out MATRIX  Out, float  CenterX, float  CenterY, float  Width, float  Height)
		{
			return dx_CreateViewportMatrix( out Out , CenterX , CenterY , Width , Height );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationXYZMatrix")]
		extern static int  dx_CreateRotationXYZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationXYZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			return dx_CreateRotationXYZMatrix( out Out , XRot , YRot , ZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationXZYMatrix")]
		extern static int  dx_CreateRotationXZYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationXZYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			return dx_CreateRotationXZYMatrix( out Out , XRot , YRot , ZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationYXZMatrix")]
		extern static int  dx_CreateRotationYXZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationYXZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			return dx_CreateRotationYXZMatrix( out Out , XRot , YRot , ZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationYZXMatrix")]
		extern static int  dx_CreateRotationYZXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationYZXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			return dx_CreateRotationYZXMatrix( out Out , XRot , YRot , ZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationZXYMatrix")]
		extern static int  dx_CreateRotationZXYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationZXYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			return dx_CreateRotationZXYMatrix( out Out , XRot , YRot , ZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationZYXMatrix")]
		extern static int  dx_CreateRotationZYXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationZYXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			return dx_CreateRotationZYXMatrix( out Out , XRot , YRot , ZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixXYZRotation")]
		extern static int  dx_GetMatrixXYZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixXYZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			return dx_GetMatrixXYZRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixXZYRotation")]
		extern static int  dx_GetMatrixXZYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixXZYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			return dx_GetMatrixXZYRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixYXZRotation")]
		extern static int  dx_GetMatrixYXZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixYXZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			return dx_GetMatrixYXZRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixYZXRotation")]
		extern static int  dx_GetMatrixYZXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixYZXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			return dx_GetMatrixYZXRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixZXYRotation")]
		extern static int  dx_GetMatrixZXYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixZXYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			return dx_GetMatrixZXYRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixZYXRotation")]
		extern static int  dx_GetMatrixZYXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixZYXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			return dx_GetMatrixZYXRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorNormalize")]
		extern static int  dx_VectorNormalize( out VECTOR  Out, out VECTOR  In);
		public static int  VectorNormalize( out VECTOR  Out, out VECTOR  In)
		{
			return dx_VectorNormalize( out Out , out In );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorScale")]
		extern static int  dx_VectorScale( out VECTOR  Out, out VECTOR  In, float  Scale);
		public static int  VectorScale( out VECTOR  Out, out VECTOR  In, float  Scale)
		{
			return dx_VectorScale( out Out , out In , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorMultiply")]
		extern static int  dx_VectorMultiply( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorMultiply( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
			return dx_VectorMultiply( out Out , out In1 , out In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorSub")]
		extern static int  dx_VectorSub( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorSub( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
			return dx_VectorSub( out Out , out In1 , out In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorAdd")]
		extern static int  dx_VectorAdd( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorAdd( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
			return dx_VectorAdd( out Out , out In1 , out In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorOuterProduct")]
		extern static int  dx_VectorOuterProduct( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorOuterProduct( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
			return dx_VectorOuterProduct( out Out , out In1 , out In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorInnerProduct")]
		extern static float  dx_VectorInnerProduct( out VECTOR  In1, out VECTOR  In2);
		public static float  VectorInnerProduct( out VECTOR  In1, out VECTOR  In2)
		{
			return dx_VectorInnerProduct( out In1 , out In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorRotationX")]
		extern static int  dx_VectorRotationX( out VECTOR  Out, out VECTOR  In, double  Angle);
		public static int  VectorRotationX( out VECTOR  Out, out VECTOR  In, double  Angle)
		{
			return dx_VectorRotationX( out Out , out In , Angle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorRotationY")]
		extern static int  dx_VectorRotationY( out VECTOR  Out, out VECTOR  In, double  Angle);
		public static int  VectorRotationY( out VECTOR  Out, out VECTOR  In, double  Angle)
		{
			return dx_VectorRotationY( out Out , out In , Angle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorRotationZ")]
		extern static int  dx_VectorRotationZ( out VECTOR  Out, out VECTOR  In, double  Angle);
		public static int  VectorRotationZ( out VECTOR  Out, out VECTOR  In, double  Angle)
		{
			return dx_VectorRotationZ( out Out , out In , Angle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorTransform")]
		extern static int  dx_VectorTransform( out VECTOR  Out, out VECTOR  InVec, out MATRIX  InMatrix);
		public static int  VectorTransform( out VECTOR  Out, out VECTOR  InVec, out MATRIX  InMatrix)
		{
			return dx_VectorTransform( out Out , out InVec , out InMatrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorTransform4")]
		extern static int  dx_VectorTransform4( out VECTOR  Out, out float  V4Out, out VECTOR  InVec, out float  V4In, out MATRIX  InMatrix);
		public static int  VectorTransform4( out VECTOR  Out, out float  V4Out, out VECTOR  InVec, out float  V4In, out MATRIX  InMatrix)
		{
			return dx_VectorTransform4( out Out , out V4Out , out InVec , out V4In , out InMatrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_TriangleBarycenter")]
		extern static void  dx_TriangleBarycenter( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  Position, out float  u, out float  v, out float  w);
		public static void  TriangleBarycenter( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  Position, out float  u, out float  v, out float  w)
		{
			dx_TriangleBarycenter( TrianglePos1 , TrianglePos2 , TrianglePos3 , Position , out u , out v , out w );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Segment_MinLength")]
		extern static float  dx_Segment_Segment_MinLength( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2);
		public static float  Segment_Segment_MinLength( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2)
		{
			return dx_Segment_Segment_MinLength( SegmentAPos1 , SegmentAPos2 , SegmentBPos1 , SegmentBPos2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Segment_MinLength_Square")]
		extern static float  dx_Segment_Segment_MinLength_Square( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2);
		public static float  Segment_Segment_MinLength_Square( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2)
		{
			return dx_Segment_Segment_MinLength_Square( SegmentAPos1 , SegmentAPos2 , SegmentBPos1 , SegmentBPos2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Triangle_MinLength")]
		extern static float  dx_Segment_Triangle_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static float  Segment_Triangle_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			return dx_Segment_Triangle_MinLength( SegmentPos1 , SegmentPos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Triangle_MinLength_Square")]
		extern static float  dx_Segment_Triangle_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static float  Segment_Triangle_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			return dx_Segment_Triangle_MinLength_Square( SegmentPos1 , SegmentPos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Point_MinLength")]
		extern static float  dx_Segment_Point_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos);
		public static float  Segment_Point_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos)
		{
			return dx_Segment_Point_MinLength( SegmentPos1 , SegmentPos2 , PointPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Point_MinLength_Square")]
		extern static float  dx_Segment_Point_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos);
		public static float  Segment_Point_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos)
		{
			return dx_Segment_Point_MinLength_Square( SegmentPos1 , SegmentPos2 , PointPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Triangle_Point_MinLength")]
		extern static float  dx_Triangle_Point_MinLength( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos);
		public static float  Triangle_Point_MinLength( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos)
		{
			return dx_Triangle_Point_MinLength( TrianglePos1 , TrianglePos2 , TrianglePos3 , PointPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Triangle_Point_MinLength_Square")]
		extern static float  dx_Triangle_Point_MinLength_Square( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos);
		public static float  Triangle_Point_MinLength_Square( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos)
		{
			return dx_Triangle_Point_MinLength_Square( TrianglePos1 , TrianglePos2 , TrianglePos3 , PointPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Plane_Point_MinLength_Position")]
		extern static VECTOR  dx_Plane_Point_MinLength_Position( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos);
		public static VECTOR  Plane_Point_MinLength_Position( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos)
		{
			return dx_Plane_Point_MinLength_Position( PlanePos , PlaneNormal , PointPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Plane_Point_MinLength")]
		extern static float  dx_Plane_Point_MinLength( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos);
		public static float  Plane_Point_MinLength( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos)
		{
			return dx_Plane_Point_MinLength( PlanePos , PlaneNormal , PointPos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Line_Triangle")]
		extern static HITRESULT_LINE  dx_HitCheck_Line_Triangle( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static HITRESULT_LINE  HitCheck_Line_Triangle( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			return dx_HitCheck_Line_Triangle( LinePos1 , LinePos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Triangle_Triangle")]
		extern static int  dx_HitCheck_Triangle_Triangle( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3);
		public static int  HitCheck_Triangle_Triangle( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3)
		{
			return dx_HitCheck_Triangle_Triangle( Triangle1Pos1 , Triangle1Pos2 , Triangle1Pos3 , Triangle2Pos1 , Triangle2Pos2 , Triangle2Pos3 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Line_Sphere")]
		extern static int  dx_HitCheck_Line_Sphere( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  SphereCenterPos, float  SphereR);
		public static int  HitCheck_Line_Sphere( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  SphereCenterPos, float  SphereR)
		{
			return dx_HitCheck_Line_Sphere( LinePos1 , LinePos2 , SphereCenterPos , SphereR );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Sphere_Sphere")]
		extern static int  dx_HitCheck_Sphere_Sphere( VECTOR  Sphere1CenterPos, float  Sphere1R, VECTOR  Sphere2CenterPos, float  Sphere2R);
		public static int  HitCheck_Sphere_Sphere( VECTOR  Sphere1CenterPos, float  Sphere1R, VECTOR  Sphere2CenterPos, float  Sphere2R)
		{
			return dx_HitCheck_Sphere_Sphere( Sphere1CenterPos , Sphere1R , Sphere2CenterPos , Sphere2R );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Sphere_Triangle")]
		extern static int  dx_HitCheck_Sphere_Triangle( VECTOR  SphereCenterPos, float  SphereR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static int  HitCheck_Sphere_Triangle( VECTOR  SphereCenterPos, float  SphereR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			return dx_HitCheck_Sphere_Triangle( SphereCenterPos , SphereR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Capsule_Capsule")]
		extern static int  dx_HitCheck_Capsule_Capsule( VECTOR  Cap1Pos1, VECTOR  Cap1Pos2, float  Cap1R, VECTOR  Cap2Pos1, VECTOR  Cap2Pos2, float  Cap2R);
		public static int  HitCheck_Capsule_Capsule( VECTOR  Cap1Pos1, VECTOR  Cap1Pos2, float  Cap1R, VECTOR  Cap2Pos1, VECTOR  Cap2Pos2, float  Cap2R)
		{
			return dx_HitCheck_Capsule_Capsule( Cap1Pos1 , Cap1Pos2 , Cap1R , Cap2Pos1 , Cap2Pos2 , Cap2R );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Capsule_Triangle")]
		extern static int  dx_HitCheck_Capsule_Triangle( VECTOR  CapPos1, VECTOR  CapPos2, float  CapR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static int  HitCheck_Capsule_Triangle( VECTOR  CapPos1, VECTOR  CapPos2, float  CapR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			return dx_HitCheck_Capsule_Triangle( CapPos1 , CapPos2 , CapR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RectClipping")]
		extern static int  dx_RectClipping( out RECT  MotoRect, out RECT  ClippuRect);
		public static int  RectClipping( out RECT  MotoRect, out RECT  ClippuRect)
		{
			return dx_RectClipping( out MotoRect , out ClippuRect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RectAdjust")]
		extern static int  dx_RectAdjust( out RECT  Rect);
		public static int  RectAdjust( out RECT  Rect)
		{
			return dx_RectAdjust( out Rect );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetRectSize")]
		extern static int  dx_GetRectSize( out RECT  Rect, out int  Width, out int  Height);
		public static int  GetRectSize( out RECT  Rect, out int  Width, out int  Height)
		{
			return dx_GetRectSize( out Rect , out Width , out Height );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetIdent")]
		extern static MATRIX  dx_MGetIdent( );
		public static MATRIX  MGetIdent( )
		{
			return dx_MGetIdent( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MMult")]
		extern static MATRIX  dx_MMult( MATRIX  In1, MATRIX  In2);
		public static MATRIX  MMult( MATRIX  In1, MATRIX  In2)
		{
			return dx_MMult( In1 , In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MScale")]
		extern static MATRIX  dx_MScale( MATRIX  InM, float  Scale);
		public static MATRIX  MScale( MATRIX  InM, float  Scale)
		{
			return dx_MScale( InM , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MAdd")]
		extern static MATRIX  dx_MAdd( MATRIX  In1, MATRIX  In2);
		public static MATRIX  MAdd( MATRIX  In1, MATRIX  In2)
		{
			return dx_MAdd( In1 , In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetScale")]
		extern static MATRIX  dx_MGetScale( VECTOR  Scale);
		public static MATRIX  MGetScale( VECTOR  Scale)
		{
			return dx_MGetScale( Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotX")]
		extern static MATRIX  dx_MGetRotX( float  XAxisRotate);
		public static MATRIX  MGetRotX( float  XAxisRotate)
		{
			return dx_MGetRotX( XAxisRotate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotY")]
		extern static MATRIX  dx_MGetRotY( float  YAxisRotate);
		public static MATRIX  MGetRotY( float  YAxisRotate)
		{
			return dx_MGetRotY( YAxisRotate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotZ")]
		extern static MATRIX  dx_MGetRotZ( float  ZAxisRotate);
		public static MATRIX  MGetRotZ( float  ZAxisRotate)
		{
			return dx_MGetRotZ( ZAxisRotate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotAxis")]
		extern static MATRIX  dx_MGetRotAxis( VECTOR  RotateAxis, float  Rotate);
		public static MATRIX  MGetRotAxis( VECTOR  RotateAxis, float  Rotate)
		{
			return dx_MGetRotAxis( RotateAxis , Rotate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotVec2")]
		extern static MATRIX  dx_MGetRotVec2( VECTOR  In1, VECTOR  In2);
		public static MATRIX  MGetRotVec2( VECTOR  In1, VECTOR  In2)
		{
			return dx_MGetRotVec2( In1 , In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetTranslate")]
		extern static MATRIX  dx_MGetTranslate( VECTOR  Trans);
		public static MATRIX  MGetTranslate( VECTOR  Trans)
		{
			return dx_MGetTranslate( Trans );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetAxis1")]
		extern static MATRIX  dx_MGetAxis1( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos);
		public static MATRIX  MGetAxis1( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos)
		{
			return dx_MGetAxis1( XAxis , YAxis , ZAxis , Pos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetAxis2")]
		extern static MATRIX  dx_MGetAxis2( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos);
		public static MATRIX  MGetAxis2( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos)
		{
			return dx_MGetAxis2( XAxis , YAxis , ZAxis , Pos );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MTranspose")]
		extern static MATRIX  dx_MTranspose( MATRIX  InM);
		public static MATRIX  MTranspose( MATRIX  InM)
		{
			return dx_MTranspose( InM );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MInverse")]
		extern static MATRIX  dx_MInverse( MATRIX  InM);
		public static MATRIX  MInverse( MATRIX  InM)
		{
			return dx_MInverse( InM );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetSize")]
		extern static VECTOR  dx_MGetSize( MATRIX  InM);
		public static VECTOR  MGetSize( MATRIX  InM)
		{
			return dx_MGetSize( InM );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VNorm")]
		extern static VECTOR  dx_VNorm( VECTOR  In);
		public static VECTOR  VNorm( VECTOR  In)
		{
			return dx_VNorm( In );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VSize")]
		extern static float  dx_VSize( VECTOR  In);
		public static float  VSize( VECTOR  In)
		{
			return dx_VSize( In );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VCos")]
		extern static float  dx_VCos( VECTOR  In1, VECTOR  In2);
		public static float  VCos( VECTOR  In1, VECTOR  In2)
		{
			return dx_VCos( In1 , In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VRad")]
		extern static float  dx_VRad( VECTOR  In1, VECTOR  In2);
		public static float  VRad( VECTOR  In1, VECTOR  In2)
		{
			return dx_VRad( In1 , In2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseFastLoadFlag")]
		extern static int  dx_SetUseFastLoadFlag( int  Flag);
		public static int  SetUseFastLoadFlag( int  Flag)
		{
			return dx_SetUseFastLoadFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphDataShavedMode")]
		extern static int  dx_GetGraphDataShavedMode( );
		public static int  GetGraphDataShavedMode( )
		{
			return dx_GetGraphDataShavedMode( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphDataShavedMode")]
		extern static int  dx_SetGraphDataShavedMode( int  ShavedMode);
		public static int  SetGraphDataShavedMode( int  ShavedMode)
		{
			return dx_SetGraphDataShavedMode( ShavedMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitSoftImage")]
		extern static int  dx_InitSoftImage( );
		public static int  InitSoftImage( )
		{
			return dx_InitSoftImage( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoftImage")]
		extern static int  dx_LoadSoftImage( string  FileName);
		public static int  LoadSoftImage( string  FileName)
		{
			return dx_LoadSoftImage( FileName );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoftImageToMem")]
		extern unsafe static int  dx_LoadSoftImageToMem( void *  FileImage, int  FileImageSize);
		public unsafe static int  LoadSoftImageToMem( void *  FileImage, int  FileImageSize)
		{
			return dx_LoadSoftImageToMem( FileImage , FileImageSize );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftImage")]
		extern static int  dx_MakeSoftImage( int  SizeX, int  SizeY);
		public static int  MakeSoftImage( int  SizeX, int  SizeY)
		{
			return dx_MakeSoftImage( SizeX , SizeY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeARGB8ColorSoftImage")]
		extern static int  dx_MakeARGB8ColorSoftImage( int  SizeX, int  SizeY);
		public static int  MakeARGB8ColorSoftImage( int  SizeX, int  SizeY)
		{
			return dx_MakeARGB8ColorSoftImage( SizeX , SizeY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeXRGB8ColorSoftImage")]
		extern static int  dx_MakeXRGB8ColorSoftImage( int  SizeX, int  SizeY);
		public static int  MakeXRGB8ColorSoftImage( int  SizeX, int  SizeY)
		{
			return dx_MakeXRGB8ColorSoftImage( SizeX , SizeY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeARGB4ColorSoftImage")]
		extern static int  dx_MakeARGB4ColorSoftImage( int  SizeX, int  SizeY);
		public static int  MakeARGB4ColorSoftImage( int  SizeX, int  SizeY)
		{
			return dx_MakeARGB4ColorSoftImage( SizeX , SizeY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeRGB8ColorSoftImage")]
		extern static int  dx_MakeRGB8ColorSoftImage( int  SizeX, int  SizeY);
		public static int  MakeRGB8ColorSoftImage( int  SizeX, int  SizeY)
		{
			return dx_MakeRGB8ColorSoftImage( SizeX , SizeY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakePAL8ColorSoftImage")]
		extern static int  dx_MakePAL8ColorSoftImage( int  SizeX, int  SizeY);
		public static int  MakePAL8ColorSoftImage( int  SizeX, int  SizeY)
		{
			return dx_MakePAL8ColorSoftImage( SizeX , SizeY );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSoftImage")]
		extern static int  dx_DeleteSoftImage( int  SIHandle);
		public static int  DeleteSoftImage( int  SIHandle)
		{
			return dx_DeleteSoftImage( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftImageSize")]
		extern static int  dx_GetSoftImageSize( int  SIHandle, out int  Width, out int  Height);
		public static int  GetSoftImageSize( int  SIHandle, out int  Width, out int  Height)
		{
			return dx_GetSoftImageSize( SIHandle , out Width , out Height );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckPaletteSoftImage")]
		extern static int  dx_CheckPaletteSoftImage( int  SIHandle);
		public static int  CheckPaletteSoftImage( int  SIHandle)
		{
			return dx_CheckPaletteSoftImage( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckAlphaSoftImage")]
		extern static int  dx_CheckAlphaSoftImage( int  SIHandle);
		public static int  CheckAlphaSoftImage( int  SIHandle)
		{
			return dx_CheckAlphaSoftImage( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckPixelAlphaSoftImage")]
		extern static int  dx_CheckPixelAlphaSoftImage( int  SIHandle);
		public static int  CheckPixelAlphaSoftImage( int  SIHandle)
		{
			return dx_CheckPixelAlphaSoftImage( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawScreenSoftImage")]
		extern static int  dx_GetDrawScreenSoftImage( int  x1, int  y1, int  x2, int  y2, int  SIHandle);
		public static int  GetDrawScreenSoftImage( int  x1, int  y1, int  x2, int  y2, int  SIHandle)
		{
			return dx_GetDrawScreenSoftImage( x1 , y1 , x2 , y2 , SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_UpdateLayerdWindowForSoftImage")]
		extern static int  dx_UpdateLayerdWindowForSoftImage( int  SIHandle);
		public static int  UpdateLayerdWindowForSoftImage( int  SIHandle)
		{
			return dx_UpdateLayerdWindowForSoftImage( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FillSoftImage")]
		extern static int  dx_FillSoftImage( int  SIHandle, int  r, int  g, int  b, int  a);
		public static int  FillSoftImage( int  SIHandle, int  r, int  g, int  b, int  a)
		{
			return dx_FillSoftImage( SIHandle , r , g , b , a );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClearRectSoftImage")]
		extern static int  dx_ClearRectSoftImage( int  SIHandle, int  x, int  y, int  w, int  h);
		public static int  ClearRectSoftImage( int  SIHandle, int  x, int  y, int  w, int  h)
		{
			return dx_ClearRectSoftImage( SIHandle , x , y , w , h );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPaletteSoftImage")]
		extern static int  dx_GetPaletteSoftImage( int  SIHandle, int  PaletteNo, out int  r, out int  g, out int  b, out int  a);
		public static int  GetPaletteSoftImage( int  SIHandle, int  PaletteNo, out int  r, out int  g, out int  b, out int  a)
		{
			return dx_GetPaletteSoftImage( SIHandle , PaletteNo , out r , out g , out b , out a );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPaletteSoftImage")]
		extern static int  dx_SetPaletteSoftImage( int  SIHandle, int  PaletteNo, int  r, int  g, int  b, int  a);
		public static int  SetPaletteSoftImage( int  SIHandle, int  PaletteNo, int  r, int  g, int  b, int  a)
		{
			return dx_SetPaletteSoftImage( SIHandle , PaletteNo , r , g , b , a );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelPalCodeSoftImage")]
		extern static int  dx_DrawPixelPalCodeSoftImage( int  SIHandle, int  x, int  y, int  palNo);
		public static int  DrawPixelPalCodeSoftImage( int  SIHandle, int  x, int  y, int  palNo)
		{
			return dx_DrawPixelPalCodeSoftImage( SIHandle , x , y , palNo );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixelPalCodeSoftImage")]
		extern static int  dx_GetPixelPalCodeSoftImage( int  SIHandle, int  x, int  y);
		public static int  GetPixelPalCodeSoftImage( int  SIHandle, int  x, int  y)
		{
			return dx_GetPixelPalCodeSoftImage( SIHandle , x , y );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetImageAddressSoftImage")]
		extern unsafe static void *  dx_GetImageAddressSoftImage( int  SIHandle);
		public unsafe static void *  GetImageAddressSoftImage( int  SIHandle)
		{
			return dx_GetImageAddressSoftImage( SIHandle );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelSoftImage")]
		extern static int  dx_DrawPixelSoftImage( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a);
		public static int  DrawPixelSoftImage( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a)
		{
			return dx_DrawPixelSoftImage( SIHandle , x , y , r , g , b , a );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelSoftImage_Unsafe_XRGB8")]
		extern static void  dx_DrawPixelSoftImage_Unsafe_XRGB8( int  SIHandle, int  x, int  y, int  r, int  g, int  b);
		public static void  DrawPixelSoftImage_Unsafe_XRGB8( int  SIHandle, int  x, int  y, int  r, int  g, int  b)
		{
			dx_DrawPixelSoftImage_Unsafe_XRGB8( SIHandle , x , y , r , g , b );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelSoftImage_Unsafe_ARGB8")]
		extern static void  dx_DrawPixelSoftImage_Unsafe_ARGB8( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a);
		public static void  DrawPixelSoftImage_Unsafe_ARGB8( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a)
		{
			dx_DrawPixelSoftImage_Unsafe_ARGB8( SIHandle , x , y , r , g , b , a );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixelSoftImage")]
		extern static int  dx_GetPixelSoftImage( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a);
		public static int  GetPixelSoftImage( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a)
		{
			return dx_GetPixelSoftImage( SIHandle , x , y , out r , out g , out b , out a );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixelSoftImage_Unsafe_XRGB8")]
		extern static void  dx_GetPixelSoftImage_Unsafe_XRGB8( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b);
		public static void  GetPixelSoftImage_Unsafe_XRGB8( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b)
		{
			dx_GetPixelSoftImage_Unsafe_XRGB8( SIHandle , x , y , out r , out g , out b );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixelSoftImage_Unsafe_ARGB8")]
		extern static void  dx_GetPixelSoftImage_Unsafe_ARGB8( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a);
		public static void  GetPixelSoftImage_Unsafe_ARGB8( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a)
		{
			dx_GetPixelSoftImage_Unsafe_ARGB8( SIHandle , x , y , out r , out g , out b , out a );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLineSoftImage")]
		extern static int  dx_DrawLineSoftImage( int  SIHandle, int  x1, int  y1, int  x2, int  y2, int  r, int  g, int  b, int  a);
		public static int  DrawLineSoftImage( int  SIHandle, int  x1, int  y1, int  x2, int  y2, int  r, int  g, int  b, int  a)
		{
			return dx_DrawLineSoftImage( SIHandle , x1 , y1 , x2 , y2 , r , g , b , a );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltSoftImage")]
		extern static int  dx_BltSoftImage( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle);
		public static int  BltSoftImage( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle)
		{
			return dx_BltSoftImage( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltSoftImageWithTransColor")]
		extern static int  dx_BltSoftImageWithTransColor( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Tr, int  Tg, int  Tb, int  Ta);
		public static int  BltSoftImageWithTransColor( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Tr, int  Tg, int  Tb, int  Ta)
		{
			return dx_BltSoftImageWithTransColor( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle , Tr , Tg , Tb , Ta );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltSoftImageWithAlphaBlend")]
		extern static int  dx_BltSoftImageWithAlphaBlend( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Opacity);
		public static int  BltSoftImageWithAlphaBlend( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle)
		{
			return dx_BltSoftImageWithAlphaBlend( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle , 255 );
		}
		public static int  BltSoftImageWithAlphaBlend( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Opacity)
		{
			return dx_BltSoftImageWithAlphaBlend( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle , Opacity );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReverseSoftImageH")]
		extern static int  dx_ReverseSoftImageH( int  SIHandle);
		public static int  ReverseSoftImageH( int  SIHandle)
		{
			return dx_ReverseSoftImageH( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReverseSoftImageV")]
		extern static int  dx_ReverseSoftImageV( int  SIHandle);
		public static int  ReverseSoftImageV( int  SIHandle)
		{
			return dx_ReverseSoftImageV( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReverseSoftImage")]
		extern static int  dx_ReverseSoftImage( int  SIHandle);
		public static int  ReverseSoftImage( int  SIHandle)
		{
			return dx_ReverseSoftImage( SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltStringSoftImage")]
		extern static int  dx_BltStringSoftImage( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  VerticalFlag);
		public static int  BltStringSoftImage( int  x, int  y, string  StrData, int  DestSIHandle)
		{
			return dx_BltStringSoftImage( x , y , StrData , DestSIHandle , -1 , FALSE );
		}
		public static int  BltStringSoftImage( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle)
		{
			return dx_BltStringSoftImage( x , y , StrData , DestSIHandle , DestEdgeSIHandle , FALSE );
		}
		public static int  BltStringSoftImage( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  VerticalFlag)
		{
			return dx_BltStringSoftImage( x , y , StrData , DestSIHandle , DestEdgeSIHandle , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltStringSoftImageToHandle")]
		extern static int  dx_BltStringSoftImageToHandle( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  FontHandle, int  VerticalFlag);
		public static int  BltStringSoftImageToHandle( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  FontHandle)
		{
			return dx_BltStringSoftImageToHandle( x , y , StrData , DestSIHandle , DestEdgeSIHandle , FontHandle , FALSE );
		}
		public static int  BltStringSoftImageToHandle( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  FontHandle, int  VerticalFlag)
		{
			return dx_BltStringSoftImageToHandle( x , y , StrData , DestSIHandle , DestEdgeSIHandle , FontHandle , VerticalFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawSoftImage")]
		extern static int  dx_DrawSoftImage( int  x, int  y, int  SIHandle);
		public static int  DrawSoftImage( int  x, int  y, int  SIHandle)
		{
			return dx_DrawSoftImage( x , y , SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveSoftImageToBmp")]
		extern static int  dx_SaveSoftImageToBmp( string  FilePath, int  SIHandle);
		public static int  SaveSoftImageToBmp( string  FilePath, int  SIHandle)
		{
			return dx_SaveSoftImageToBmp( FilePath , SIHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveSoftImageToPng")]
		extern static int  dx_SaveSoftImageToPng( string  FilePath, int  SIHandle, int  CompressionLevel);
		public static int  SaveSoftImageToPng( string  FilePath, int  SIHandle, int  CompressionLevel)
		{
			return dx_SaveSoftImageToPng( FilePath , SIHandle , CompressionLevel );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveSoftImageToJpeg")]
		extern static int  dx_SaveSoftImageToJpeg( string  FilePath, int  SIHandle, int  Quality, int  Sample2x1);
		public static int  SaveSoftImageToJpeg( string  FilePath, int  SIHandle, int  Quality, int  Sample2x1)
		{
			return dx_SaveSoftImageToJpeg( FilePath , SIHandle , Quality , Sample2x1 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColorF")]
		extern static COLOR_F  dx_GetColorF( float  Red, float  Green, float  Blue, float  Alpha);
		public static COLOR_F  GetColorF( float  Red, float  Green, float  Blue, float  Alpha)
		{
			return dx_GetColorF( Red , Green , Blue , Alpha );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColorU8")]
		extern static COLOR_U8  dx_GetColorU8( int  Red, int  Green, int  Blue, int  Alpha);
		public static COLOR_U8  GetColorU8( int  Red, int  Green, int  Blue, int  Alpha)
		{
			return dx_GetColorU8( Red , Green , Blue , Alpha );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor")]
		extern static int  dx_GetColor( int  Red, int  Green, int  Blue);
		public static int  GetColor( int  Red, int  Green, int  Blue)
		{
			return dx_GetColor( Red , Green , Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor2")]
		extern static int  dx_GetColor2( int  Color, out int  Red, out int  Green, out int  Blue);
		public static int  GetColor2( int  Color, out int  Red, out int  Green, out int  Blue)
		{
			return dx_GetColor2( Color , out Red , out Green , out Blue );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor3")]
		extern static int  dx_GetColor3( out COLORDATA  ColorData, int  Red, int  Green, int  Blue, int  Alpha);
		public static int  GetColor3( out COLORDATA  ColorData, int  Red, int  Green, int  Blue)
		{
			return dx_GetColor3( out ColorData , Red , Green , Blue , 255 );
		}
		public static int  GetColor3( out COLORDATA  ColorData, int  Red, int  Green, int  Blue, int  Alpha)
		{
			return dx_GetColor3( out ColorData , Red , Green , Blue , Alpha );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor4")]
		extern static int  dx_GetColor4( out COLORDATA  DestColorData, out COLORDATA  SrcColorData, int  SrcColor);
		public static int  GetColor4( out COLORDATA  DestColorData, out COLORDATA  SrcColorData, int  SrcColor)
		{
			return dx_GetColor4( out DestColorData , out SrcColorData , SrcColor );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor5")]
		extern static int  dx_GetColor5( out COLORDATA  ColorData, int  Color, out int  Red, out int  Green, out int  Blue, out int  Alpha);
		public static int  GetColor5( out COLORDATA  ColorData, int  Color, out int  Red, out int  Green, out int  Blue, out int  Alpha)
		{
			return dx_GetColor5( out ColorData , Color , out Red , out Green , out Blue , out Alpha );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePaletteColorData")]
		extern static int  dx_CreatePaletteColorData( out COLORDATA  ColorDataBuf);
		public static int  CreatePaletteColorData( out COLORDATA  ColorDataBuf)
		{
			return dx_CreatePaletteColorData( out ColorDataBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateXRGB8ColorData")]
		extern static int  dx_CreateXRGB8ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateXRGB8ColorData( out COLORDATA  ColorDataBuf)
		{
			return dx_CreateXRGB8ColorData( out ColorDataBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateARGB8ColorData")]
		extern static int  dx_CreateARGB8ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateARGB8ColorData( out COLORDATA  ColorDataBuf)
		{
			return dx_CreateARGB8ColorData( out ColorDataBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateARGB4ColorData")]
		extern static int  dx_CreateARGB4ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateARGB4ColorData( out COLORDATA  ColorDataBuf)
		{
			return dx_CreateARGB4ColorData( out ColorDataBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateFullColorData")]
		extern static int  dx_CreateFullColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateFullColorData( out COLORDATA  ColorDataBuf)
		{
			return dx_CreateFullColorData( out ColorDataBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateGrayColorData")]
		extern static int  dx_CreateGrayColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateGrayColorData( out COLORDATA  ColorDataBuf)
		{
			return dx_CreateGrayColorData( out ColorDataBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePal8ColorData")]
		extern static int  dx_CreatePal8ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreatePal8ColorData( out COLORDATA  ColorDataBuf)
		{
			return dx_CreatePal8ColorData( out ColorDataBuf );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateColorData")]
		extern static int  dx_CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask);
		public static int  CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask)
		{
			return dx_CreateColorData( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetColorDataNoneMask")]
		extern static void  dx_SetColorDataNoneMask( out COLORDATA  ColorData);
		public static void  SetColorDataNoneMask( out COLORDATA  ColorData)
		{
			dx_SetColorDataNoneMask( out ColorData );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CmpColorData")]
		extern static int  dx_CmpColorData( out COLORDATA  ColorData1, out COLORDATA  ColorData2);
		public static int  CmpColorData( out COLORDATA  ColorData1, out COLORDATA  ColorData2)
		{
			return dx_CmpColorData( out ColorData1 , out ColorData2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitSoundMem")]
		extern static int  dx_InitSoundMem( int  LogOutFlag);
		public static int  InitSoundMem( )
		{
			return dx_InitSoundMem( FALSE );
		}
		public static int  InitSoundMem( int  LogOutFlag)
		{
			return dx_InitSoundMem( LogOutFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddSoundData")]
		extern static int  dx_AddSoundData( int  Handle);
		public static int  AddSoundData( )
		{
			return dx_AddSoundData( -1 );
		}
		public static int  AddSoundData( int  Handle)
		{
			return dx_AddSoundData( Handle );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_AddStreamSoundMemToMem")]
		extern unsafe static int  dx_AddStreamSoundMemToMem( void *  FileImageBuffer, int  ImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle);
		public unsafe static int  AddStreamSoundMemToMem( void *  FileImageBuffer, int  ImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType)
		{
			return dx_AddStreamSoundMemToMem( FileImageBuffer , ImageSize , LoopNum , SoundHandle , StreamDataType , -1 );
		}
		public unsafe static int  AddStreamSoundMemToMem( void *  FileImageBuffer, int  ImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle)
		{
			return dx_AddStreamSoundMemToMem( FileImageBuffer , ImageSize , LoopNum , SoundHandle , StreamDataType , UnionHandle );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_AddStreamSoundMemToFile")]
		extern static int  dx_AddStreamSoundMemToFile( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle);
		public static int  AddStreamSoundMemToFile( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType)
		{
			return dx_AddStreamSoundMemToFile( WaveFile , LoopNum , SoundHandle , StreamDataType , -1 );
		}
		public static int  AddStreamSoundMemToFile( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle)
		{
			return dx_AddStreamSoundMemToFile( WaveFile , LoopNum , SoundHandle , StreamDataType , UnionHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupStreamSoundMem")]
		extern static int  dx_SetupStreamSoundMem( int  SoundHandle);
		public static int  SetupStreamSoundMem( int  SoundHandle)
		{
			return dx_SetupStreamSoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayStreamSoundMem")]
		extern static int  dx_PlayStreamSoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag);
		public static int  PlayStreamSoundMem( int  SoundHandle)
		{
			return dx_PlayStreamSoundMem( SoundHandle , DX_PLAYTYPE_LOOP , TRUE );
		}
		public static int  PlayStreamSoundMem( int  SoundHandle, int  PlayType)
		{
			return dx_PlayStreamSoundMem( SoundHandle , PlayType , TRUE );
		}
		public static int  PlayStreamSoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag)
		{
			return dx_PlayStreamSoundMem( SoundHandle , PlayType , TopPositionFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckStreamSoundMem")]
		extern static int  dx_CheckStreamSoundMem( int  SoundHandle);
		public static int  CheckStreamSoundMem( int  SoundHandle)
		{
			return dx_CheckStreamSoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopStreamSoundMem")]
		extern static int  dx_StopStreamSoundMem( int  SoundHandle);
		public static int  StopStreamSoundMem( int  SoundHandle)
		{
			return dx_StopStreamSoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetStreamSoundCurrentPosition")]
		extern static int  dx_SetStreamSoundCurrentPosition( int  Byte, int  SoundHandle);
		public static int  SetStreamSoundCurrentPosition( int  Byte, int  SoundHandle)
		{
			return dx_SetStreamSoundCurrentPosition( Byte , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStreamSoundCurrentPosition")]
		extern static int  dx_GetStreamSoundCurrentPosition( int  SoundHandle);
		public static int  GetStreamSoundCurrentPosition( int  SoundHandle)
		{
			return dx_GetStreamSoundCurrentPosition( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetStreamSoundCurrentTime")]
		extern static int  dx_SetStreamSoundCurrentTime( int  Time, int  SoundHandle);
		public static int  SetStreamSoundCurrentTime( int  Time, int  SoundHandle)
		{
			return dx_SetStreamSoundCurrentTime( Time , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStreamSoundCurrentTime")]
		extern static int  dx_GetStreamSoundCurrentTime( int  SoundHandle);
		public static int  GetStreamSoundCurrentTime( int  SoundHandle)
		{
			return dx_GetStreamSoundCurrentTime( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessStreamSoundMem")]
		extern static int  dx_ProcessStreamSoundMem( int  SoundHandle);
		public static int  ProcessStreamSoundMem( int  SoundHandle)
		{
			return dx_ProcessStreamSoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessStreamSoundMemAll")]
		extern static int  dx_ProcessStreamSoundMemAll( );
		public static int  ProcessStreamSoundMemAll( )
		{
			return dx_ProcessStreamSoundMemAll( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMem2")]
		extern static int  dx_LoadSoundMem2( string  WaveName1, string  WaveName2);
		public static int  LoadSoundMem2( string  WaveName1, string  WaveName2)
		{
			return dx_LoadSoundMem2( WaveName1 , WaveName2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadBGM")]
		extern static int  dx_LoadBGM( string  WaveName);
		public static int  LoadBGM( string  WaveName)
		{
			return dx_LoadBGM( WaveName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemBase")]
		extern static int  dx_LoadSoundMemBase( string  WaveName, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMemBase( string  WaveName, int  BufferNum)
		{
			return dx_LoadSoundMemBase( WaveName , BufferNum , -1 );
		}
		public static int  LoadSoundMemBase( string  WaveName, int  BufferNum, int  UnionHandle)
		{
			return dx_LoadSoundMemBase( WaveName , BufferNum , UnionHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMem")]
		extern static int  dx_LoadSoundMem( string  WaveName, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMem( string  WaveName)
		{
			return dx_LoadSoundMem( WaveName , 3 , -1 );
		}
		public static int  LoadSoundMem( string  WaveName, int  BufferNum)
		{
			return dx_LoadSoundMem( WaveName , BufferNum , -1 );
		}
		public static int  LoadSoundMem( string  WaveName, int  BufferNum, int  UnionHandle)
		{
			return dx_LoadSoundMem( WaveName , BufferNum , UnionHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemToBufNumSitei")]
		extern static int  dx_LoadSoundMemToBufNumSitei( string  WaveName, int  BufferNum);
		public static int  LoadSoundMemToBufNumSitei( string  WaveName, int  BufferNum)
		{
			return dx_LoadSoundMemToBufNumSitei( WaveName , BufferNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemByResource")]
		extern static int  dx_LoadSoundMemByResource( string  ResourceName, string  ResourceType, int  BufferNum);
		public static int  LoadSoundMemByResource( string  ResourceName, string  ResourceType)
		{
			return dx_LoadSoundMemByResource( ResourceName , ResourceType , 1 );
		}
		public static int  LoadSoundMemByResource( string  ResourceName, string  ResourceType, int  BufferNum)
		{
			return dx_LoadSoundMemByResource( ResourceName , ResourceType , BufferNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DuplicateSoundMem")]
		extern static int  dx_DuplicateSoundMem( int  SrcSoundHandle, int  BufferNum);
		public static int  DuplicateSoundMem( int  SrcSoundHandle)
		{
			return dx_DuplicateSoundMem( SrcSoundHandle , 3 );
		}
		public static int  DuplicateSoundMem( int  SrcSoundHandle, int  BufferNum)
		{
			return dx_DuplicateSoundMem( SrcSoundHandle , BufferNum );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemByMemImageBase")]
		extern unsafe static int  dx_LoadSoundMemByMemImageBase( void *  FileImageBuffer, int  ImageSize, int  BufferNum, int  UnionHandle);
		public unsafe static int  LoadSoundMemByMemImageBase( void *  FileImageBuffer, int  ImageSize, int  BufferNum)
		{
			return dx_LoadSoundMemByMemImageBase( FileImageBuffer , ImageSize , BufferNum , -1 );
		}
		public unsafe static int  LoadSoundMemByMemImageBase( void *  FileImageBuffer, int  ImageSize, int  BufferNum, int  UnionHandle)
		{
			return dx_LoadSoundMemByMemImageBase( FileImageBuffer , ImageSize , BufferNum , UnionHandle );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemByMemImage")]
		extern unsafe static int  dx_LoadSoundMemByMemImage( void *  FileImageBuffer, int  ImageSize, int  UnionHandle);
		public unsafe static int  LoadSoundMemByMemImage( void *  FileImageBuffer, int  ImageSize)
		{
			return dx_LoadSoundMemByMemImage( FileImageBuffer , ImageSize , -1 );
		}
		public unsafe static int  LoadSoundMemByMemImage( void *  FileImageBuffer, int  ImageSize, int  UnionHandle)
		{
			return dx_LoadSoundMemByMemImage( FileImageBuffer , ImageSize , UnionHandle );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemByMemImageToBufNumSitei")]
		extern unsafe static int  dx_LoadSoundMemByMemImageToBufNumSitei( void *  FileImageBuffer, int  ImageSize, int  BufferNum);
		public unsafe static int  LoadSoundMemByMemImageToBufNumSitei( void *  FileImageBuffer, int  ImageSize, int  BufferNum)
		{
			return dx_LoadSoundMemByMemImageToBufNumSitei( FileImageBuffer , ImageSize , BufferNum );
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMem2ByMemImage")]
		extern unsafe static int  dx_LoadSoundMem2ByMemImage( void *  FileImageBuffer1, int  ImageSize1, void *  FileImageBuffer2, int  ImageSize2);
		public unsafe static int  LoadSoundMem2ByMemImage( void *  FileImageBuffer1, int  ImageSize1, void *  FileImageBuffer2, int  ImageSize2)
		{
			return dx_LoadSoundMem2ByMemImage( FileImageBuffer1 , ImageSize1 , FileImageBuffer2 , ImageSize2 );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemFromSoftSound")]
		extern static int  dx_LoadSoundMemFromSoftSound( int  SoftSoundHandle, int  BufferNum);
		public static int  LoadSoundMemFromSoftSound( int  SoftSoundHandle)
		{
			return dx_LoadSoundMemFromSoftSound( SoftSoundHandle , 3 );
		}
		public static int  LoadSoundMemFromSoftSound( int  SoftSoundHandle, int  BufferNum)
		{
			return dx_LoadSoundMemFromSoftSound( SoftSoundHandle , BufferNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSoundMem")]
		extern static int  dx_DeleteSoundMem( int  SoundHandle, int  LogOutFlag);
		public static int  DeleteSoundMem( int  SoundHandle)
		{
			return dx_DeleteSoundMem( SoundHandle , FALSE );
		}
		public static int  DeleteSoundMem( int  SoundHandle, int  LogOutFlag)
		{
			return dx_DeleteSoundMem( SoundHandle , LogOutFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlaySoundMem")]
		extern static int  dx_PlaySoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag);
		public static int  PlaySoundMem( int  SoundHandle, int  PlayType)
		{
			return dx_PlaySoundMem( SoundHandle , PlayType , TRUE );
		}
		public static int  PlaySoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag)
		{
			return dx_PlaySoundMem( SoundHandle , PlayType , TopPositionFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopSoundMem")]
		extern static int  dx_StopSoundMem( int  SoundHandle);
		public static int  StopSoundMem( int  SoundHandle)
		{
			return dx_StopSoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckSoundMem")]
		extern static int  dx_CheckSoundMem( int  SoundHandle);
		public static int  CheckSoundMem( int  SoundHandle)
		{
			return dx_CheckSoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPanSoundMem")]
		extern static int  dx_SetPanSoundMem( int  PanPal, int  SoundHandle);
		public static int  SetPanSoundMem( int  PanPal, int  SoundHandle)
		{
			return dx_SetPanSoundMem( PanPal , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPanSoundMem")]
		extern static int  dx_GetPanSoundMem( int  SoundHandle);
		public static int  GetPanSoundMem( int  SoundHandle)
		{
			return dx_GetPanSoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVolumeSoundMem")]
		extern static int  dx_SetVolumeSoundMem( int  VolumePal, int  SoundHandle);
		public static int  SetVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
			return dx_SetVolumeSoundMem( VolumePal , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeVolumeSoundMem")]
		extern static int  dx_ChangeVolumeSoundMem( int  VolumePal, int  SoundHandle);
		public static int  ChangeVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
			return dx_ChangeVolumeSoundMem( VolumePal , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetVolumeSoundMem")]
		extern static int  dx_GetVolumeSoundMem( int  SoundHandle);
		public static int  GetVolumeSoundMem( int  SoundHandle)
		{
			return dx_GetVolumeSoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFrequencySoundMem")]
		extern static int  dx_SetFrequencySoundMem( int  FrequencyPal, int  SoundHandle);
		public static int  SetFrequencySoundMem( int  FrequencyPal, int  SoundHandle)
		{
			return dx_SetFrequencySoundMem( FrequencyPal , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFrequencySoundMem")]
		extern static int  dx_GetFrequencySoundMem( int  SoundHandle);
		public static int  GetFrequencySoundMem( int  SoundHandle)
		{
			return dx_GetFrequencySoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetFrequencySoundMem")]
		extern static int  dx_ResetFrequencySoundMem( int  SoundHandle);
		public static int  ResetFrequencySoundMem( int  SoundHandle)
		{
			return dx_ResetFrequencySoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNextPlayPanSoundMem")]
		extern static int  dx_SetNextPlayPanSoundMem( int  PanPal, int  SoundHandle);
		public static int  SetNextPlayPanSoundMem( int  PanPal, int  SoundHandle)
		{
			return dx_SetNextPlayPanSoundMem( PanPal , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNextPlayVolumeSoundMem")]
		extern static int  dx_SetNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle);
		public static int  SetNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
			return dx_SetNextPlayVolumeSoundMem( VolumePal , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeNextPlayVolumeSoundMem")]
		extern static int  dx_ChangeNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle);
		public static int  ChangeNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
			return dx_ChangeNextPlayVolumeSoundMem( VolumePal , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNextPlayFrequencySoundMem")]
		extern static int  dx_SetNextPlayFrequencySoundMem( int  FrequencyPal, int  SoundHandle);
		public static int  SetNextPlayFrequencySoundMem( int  FrequencyPal, int  SoundHandle)
		{
			return dx_SetNextPlayFrequencySoundMem( FrequencyPal , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCurrentPositionSoundMem")]
		extern static int  dx_SetCurrentPositionSoundMem( int  SamplePosition, int  SoundHandle);
		public static int  SetCurrentPositionSoundMem( int  SamplePosition, int  SoundHandle)
		{
			return dx_SetCurrentPositionSoundMem( SamplePosition , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCurrentPositionSoundMem")]
		extern static int  dx_GetCurrentPositionSoundMem( int  SoundHandle);
		public static int  GetCurrentPositionSoundMem( int  SoundHandle)
		{
			return dx_GetCurrentPositionSoundMem( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetSoundCurrentPosition")]
		extern static int  dx_SetSoundCurrentPosition( int  Byte, int  SoundHandle);
		public static int  SetSoundCurrentPosition( int  Byte, int  SoundHandle)
		{
			return dx_SetSoundCurrentPosition( Byte , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoundCurrentPosition")]
		extern static int  dx_GetSoundCurrentPosition( int  SoundHandle);
		public static int  GetSoundCurrentPosition( int  SoundHandle)
		{
			return dx_GetSoundCurrentPosition( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetSoundCurrentTime")]
		extern static int  dx_SetSoundCurrentTime( int  Time, int  SoundHandle);
		public static int  SetSoundCurrentTime( int  Time, int  SoundHandle)
		{
			return dx_SetSoundCurrentTime( Time , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoundCurrentTime")]
		extern static int  dx_GetSoundCurrentTime( int  SoundHandle);
		public static int  GetSoundCurrentTime( int  SoundHandle)
		{
			return dx_GetSoundCurrentTime( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoundTotalSample")]
		extern static int  dx_GetSoundTotalSample( int  SoundHandle);
		public static int  GetSoundTotalSample( int  SoundHandle)
		{
			return dx_GetSoundTotalSample( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoundTotalTime")]
		extern static int  dx_GetSoundTotalTime( int  SoundHandle);
		public static int  GetSoundTotalTime( int  SoundHandle)
		{
			return dx_GetSoundTotalTime( SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopPosSoundMem")]
		extern static int  dx_SetLoopPosSoundMem( int  LoopTime, int  SoundHandle);
		public static int  SetLoopPosSoundMem( int  LoopTime, int  SoundHandle)
		{
			return dx_SetLoopPosSoundMem( LoopTime , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopTimePosSoundMem")]
		extern static int  dx_SetLoopTimePosSoundMem( int  LoopTime, int  SoundHandle);
		public static int  SetLoopTimePosSoundMem( int  LoopTime, int  SoundHandle)
		{
			return dx_SetLoopTimePosSoundMem( LoopTime , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopSamplePosSoundMem")]
		extern static int  dx_SetLoopSamplePosSoundMem( int  LoopSamplePosition, int  SoundHandle);
		public static int  SetLoopSamplePosSoundMem( int  LoopSamplePosition, int  SoundHandle)
		{
			return dx_SetLoopSamplePosSoundMem( LoopSamplePosition , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopStartTimePosSoundMem")]
		extern static int  dx_SetLoopStartTimePosSoundMem( int  LoopStartTime, int  SoundHandle);
		public static int  SetLoopStartTimePosSoundMem( int  LoopStartTime, int  SoundHandle)
		{
			return dx_SetLoopStartTimePosSoundMem( LoopStartTime , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopStartSamplePosSoundMem")]
		extern static int  dx_SetLoopStartSamplePosSoundMem( int  LoopStartSamplePosition, int  SoundHandle);
		public static int  SetLoopStartSamplePosSoundMem( int  LoopStartSamplePosition, int  SoundHandle)
		{
			return dx_SetLoopStartSamplePosSoundMem( LoopStartSamplePosition , SoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCreateSoundDataType")]
		extern static int  dx_SetCreateSoundDataType( int  SoundDataType);
		public static int  SetCreateSoundDataType( int  SoundDataType)
		{
			return dx_SetCreateSoundDataType( SoundDataType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCreateSoundDataType")]
		extern static int  dx_GetCreateSoundDataType( );
		public static int  GetCreateSoundDataType( )
		{
			return dx_GetCreateSoundDataType( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDisableReadSoundFunctionMask")]
		extern static int  dx_SetDisableReadSoundFunctionMask( int  Mask);
		public static int  SetDisableReadSoundFunctionMask( int  Mask)
		{
			return dx_SetDisableReadSoundFunctionMask( Mask );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDisableReadSoundFunctionMask")]
		extern static int  dx_GetDisableReadSoundFunctionMask( );
		public static int  GetDisableReadSoundFunctionMask( )
		{
			return dx_GetDisableReadSoundFunctionMask( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetEnableSoundCaptureFlag")]
		extern static int  dx_SetEnableSoundCaptureFlag( int  Flag);
		public static int  SetEnableSoundCaptureFlag( int  Flag)
		{
			return dx_SetEnableSoundCaptureFlag( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseSoftwareMixingSoundFlag")]
		extern static int  dx_SetUseSoftwareMixingSoundFlag( int  Flag);
		public static int  SetUseSoftwareMixingSoundFlag( int  Flag)
		{
			return dx_SetUseSoftwareMixingSoundFlag( Flag );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetDSoundObj")]
		extern unsafe static void *  dx_GetDSoundObj( );
		public unsafe static void *  GetDSoundObj( )
		{
			return dx_GetDSoundObj( );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_PlaySoundFile")]
		extern static int  dx_PlaySoundFile( string  FileName, int  PlayType);
		public static int  PlaySoundFile( string  FileName, int  PlayType)
		{
			return dx_PlaySoundFile( FileName , PlayType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlaySound")]
		extern static int  dx_PlaySound( string  FileName, int  PlayType);
		public static int  PlaySound( string  FileName, int  PlayType)
		{
			return dx_PlaySound( FileName , PlayType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckSoundFile")]
		extern static int  dx_CheckSoundFile( );
		public static int  CheckSoundFile( )
		{
			return dx_CheckSoundFile( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckSound")]
		extern static int  dx_CheckSound( );
		public static int  CheckSound( )
		{
			return dx_CheckSound( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopSoundFile")]
		extern static int  dx_StopSoundFile( );
		public static int  StopSoundFile( )
		{
			return dx_StopSoundFile( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopSound")]
		extern static int  dx_StopSound( );
		public static int  StopSound( )
		{
			return dx_StopSound( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVolumeSoundFile")]
		extern static int  dx_SetVolumeSoundFile( int  VolumePal);
		public static int  SetVolumeSoundFile( int  VolumePal)
		{
			return dx_SetVolumeSoundFile( VolumePal );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVolumeSound")]
		extern static int  dx_SetVolumeSound( int  VolumePal);
		public static int  SetVolumeSound( int  VolumePal)
		{
			return dx_SetVolumeSound( VolumePal );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitSoftSound")]
		extern static int  dx_InitSoftSound( );
		public static int  InitSoftSound( )
		{
			return dx_InitSoftSound( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoftSound")]
		extern static int  dx_LoadSoftSound( string  FileName);
		public static int  LoadSoftSound( string  FileName)
		{
			return dx_LoadSoftSound( FileName );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoftSoundFromMemImage")]
		extern unsafe static int  dx_LoadSoftSoundFromMemImage( void *  FileImageBuffer, int  FileImageSize);
		public unsafe static int  LoadSoftSoundFromMemImage( void *  FileImageBuffer, int  FileImageSize)
		{
			return dx_LoadSoftSoundFromMemImage( FileImageBuffer , FileImageSize );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound")]
		extern static int  dx_MakeSoftSound( int  UseFormat_SoftSoundHandle, int  SampleNum);
		public static int  MakeSoftSound( int  UseFormat_SoftSoundHandle, int  SampleNum)
		{
			return dx_MakeSoftSound( UseFormat_SoftSoundHandle , SampleNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound2Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSound2Ch16Bit44KHz( int  SampleNum);
		public static int  MakeSoftSound2Ch16Bit44KHz( int  SampleNum)
		{
			return dx_MakeSoftSound2Ch16Bit44KHz( SampleNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound2Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSound2Ch16Bit22KHz( int  SampleNum);
		public static int  MakeSoftSound2Ch16Bit22KHz( int  SampleNum)
		{
			return dx_MakeSoftSound2Ch16Bit22KHz( SampleNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound2Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSound2Ch8Bit44KHz( int  SampleNum);
		public static int  MakeSoftSound2Ch8Bit44KHz( int  SampleNum)
		{
			return dx_MakeSoftSound2Ch8Bit44KHz( SampleNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound2Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSound2Ch8Bit22KHz( int  SampleNum);
		public static int  MakeSoftSound2Ch8Bit22KHz( int  SampleNum)
		{
			return dx_MakeSoftSound2Ch8Bit22KHz( SampleNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound1Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSound1Ch16Bit44KHz( int  SampleNum);
		public static int  MakeSoftSound1Ch16Bit44KHz( int  SampleNum)
		{
			return dx_MakeSoftSound1Ch16Bit44KHz( SampleNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound1Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSound1Ch16Bit22KHz( int  SampleNum);
		public static int  MakeSoftSound1Ch16Bit22KHz( int  SampleNum)
		{
			return dx_MakeSoftSound1Ch16Bit22KHz( SampleNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound1Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSound1Ch8Bit44KHz( int  SampleNum);
		public static int  MakeSoftSound1Ch8Bit44KHz( int  SampleNum)
		{
			return dx_MakeSoftSound1Ch8Bit44KHz( SampleNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound1Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSound1Ch8Bit22KHz( int  SampleNum);
		public static int  MakeSoftSound1Ch8Bit22KHz( int  SampleNum)
		{
			return dx_MakeSoftSound1Ch8Bit22KHz( SampleNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSoftSound")]
		extern static int  dx_DeleteSoftSound( int  SoftSoundHandle);
		public static int  DeleteSoftSound( int  SoftSoundHandle)
		{
			return dx_DeleteSoftSound( SoftSoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveSoftSound")]
		extern static int  dx_SaveSoftSound( int  SoftSoundHandle, string  FileName);
		public static int  SaveSoftSound( int  SoftSoundHandle, string  FileName)
		{
			return dx_SaveSoftSound( SoftSoundHandle , FileName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftSoundSampleNum")]
		extern static int  dx_GetSoftSoundSampleNum( int  SoftSoundHandle);
		public static int  GetSoftSoundSampleNum( int  SoftSoundHandle)
		{
			return dx_GetSoftSoundSampleNum( SoftSoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftSoundFormat")]
		extern static int  dx_GetSoftSoundFormat( int  SoftSoundHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec);
		public static int  GetSoftSoundFormat( int  SoftSoundHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec)
		{
			return dx_GetSoftSoundFormat( SoftSoundHandle , out Channels , out BitsPerSample , out SamplesPerSec );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReadSoftSoundData")]
		extern static int  dx_ReadSoftSoundData( int  SoftSoundHandle, int  SamplePosition, out int  Channel1, out int  Channel2);
		public static int  ReadSoftSoundData( int  SoftSoundHandle, int  SamplePosition, out int  Channel1, out int  Channel2)
		{
			return dx_ReadSoftSoundData( SoftSoundHandle , SamplePosition , out Channel1 , out Channel2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_WriteSoftSoundData")]
		extern static int  dx_WriteSoftSoundData( int  SoftSoundHandle, int  SamplePosition, int  Channel1, int  Channel2);
		public static int  WriteSoftSoundData( int  SoftSoundHandle, int  SamplePosition, int  Channel1, int  Channel2)
		{
			return dx_WriteSoftSoundData( SoftSoundHandle , SamplePosition , Channel1 , Channel2 );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftSoundDataImage")]
		extern unsafe static void *  dx_GetSoftSoundDataImage( int  SoftSoundHandle);
		public unsafe static void *  GetSoftSoundDataImage( int  SoftSoundHandle)
		{
			return dx_GetSoftSoundDataImage( SoftSoundHandle );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_InitSoftSoundPlayer")]
		extern static int  dx_InitSoftSoundPlayer( );
		public static int  InitSoftSoundPlayer( )
		{
			return dx_InitSoftSoundPlayer( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer")]
		extern static int  dx_MakeSoftSoundPlayer( int  UseFormat_SoftSoundHandle);
		public static int  MakeSoftSoundPlayer( int  UseFormat_SoftSoundHandle)
		{
			return dx_MakeSoftSoundPlayer( UseFormat_SoftSoundHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch16Bit44KHz( );
		public static int  MakeSoftSoundPlayer2Ch16Bit44KHz( )
		{
			return dx_MakeSoftSoundPlayer2Ch16Bit44KHz( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch16Bit22KHz( );
		public static int  MakeSoftSoundPlayer2Ch16Bit22KHz( )
		{
			return dx_MakeSoftSoundPlayer2Ch16Bit22KHz( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch8Bit44KHz( );
		public static int  MakeSoftSoundPlayer2Ch8Bit44KHz( )
		{
			return dx_MakeSoftSoundPlayer2Ch8Bit44KHz( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch8Bit22KHz( );
		public static int  MakeSoftSoundPlayer2Ch8Bit22KHz( )
		{
			return dx_MakeSoftSoundPlayer2Ch8Bit22KHz( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch16Bit44KHz( );
		public static int  MakeSoftSoundPlayer1Ch16Bit44KHz( )
		{
			return dx_MakeSoftSoundPlayer1Ch16Bit44KHz( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch16Bit22KHz( );
		public static int  MakeSoftSoundPlayer1Ch16Bit22KHz( )
		{
			return dx_MakeSoftSoundPlayer1Ch16Bit22KHz( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch8Bit44KHz( );
		public static int  MakeSoftSoundPlayer1Ch8Bit44KHz( )
		{
			return dx_MakeSoftSoundPlayer1Ch8Bit44KHz( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch8Bit22KHz( );
		public static int  MakeSoftSoundPlayer1Ch8Bit22KHz( )
		{
			return dx_MakeSoftSoundPlayer1Ch8Bit22KHz( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSoftSoundPlayer")]
		extern static int  dx_DeleteSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  DeleteSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			return dx_DeleteSoftSoundPlayer( SSoundPlayerHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddDataSoftSoundPlayer")]
		extern static int  dx_AddDataSoftSoundPlayer( int  SSoundPlayerHandle, int  SoftSoundHandle, int  AddSamplePosition, int  AddSampleNum);
		public static int  AddDataSoftSoundPlayer( int  SSoundPlayerHandle, int  SoftSoundHandle, int  AddSamplePosition, int  AddSampleNum)
		{
			return dx_AddDataSoftSoundPlayer( SSoundPlayerHandle , SoftSoundHandle , AddSamplePosition , AddSampleNum );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_AddDirectDataSoftSoundPlayer")]
		extern unsafe static int  dx_AddDirectDataSoftSoundPlayer( int  SSoundPlayerHandle, void *  SoundData, int  AddSampleNum);
		public unsafe static int  AddDirectDataSoftSoundPlayer( int  SSoundPlayerHandle, void *  SoundData, int  AddSampleNum)
		{
			return dx_AddDirectDataSoftSoundPlayer( SSoundPlayerHandle , SoundData , AddSampleNum );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_AddOneDataSoftSoundPlayer")]
		extern static int  dx_AddOneDataSoftSoundPlayer( int  SSoundPlayerHandle, int  Channel1, int  Channel2);
		public static int  AddOneDataSoftSoundPlayer( int  SSoundPlayerHandle, int  Channel1, int  Channel2)
		{
			return dx_AddOneDataSoftSoundPlayer( SSoundPlayerHandle , Channel1 , Channel2 );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftSoundPlayerFormat")]
		extern static int  dx_GetSoftSoundPlayerFormat( int  SSoundPlayerHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec);
		public static int  GetSoftSoundPlayerFormat( int  SSoundPlayerHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec)
		{
			return dx_GetSoftSoundPlayerFormat( SSoundPlayerHandle , out Channels , out BitsPerSample , out SamplesPerSec );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StartSoftSoundPlayer")]
		extern static int  dx_StartSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  StartSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			return dx_StartSoftSoundPlayer( SSoundPlayerHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckStartSoftSoundPlayer")]
		extern static int  dx_CheckStartSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  CheckStartSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			return dx_CheckStartSoftSoundPlayer( SSoundPlayerHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopSoftSoundPlayer")]
		extern static int  dx_StopSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  StopSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			return dx_StopSoftSoundPlayer( SSoundPlayerHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetSoftSoundPlayer")]
		extern static int  dx_ResetSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  ResetSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			return dx_ResetSoftSoundPlayer( SSoundPlayerHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStockDataLengthSoftSoundPlayer")]
		extern static int  dx_GetStockDataLengthSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  GetStockDataLengthSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			return dx_GetStockDataLengthSoftSoundPlayer( SSoundPlayerHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckSoftSoundPlayerNoneData")]
		extern static int  dx_CheckSoftSoundPlayerNoneData( int  SSoundPlayerHandle);
		public static int  CheckSoftSoundPlayerNoneData( int  SSoundPlayerHandle)
		{
			return dx_CheckSoftSoundPlayerNoneData( SSoundPlayerHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMusicData")]
		extern static int  dx_AddMusicData( );
		public static int  AddMusicData( )
		{
			return dx_AddMusicData( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMusicMem")]
		extern static int  dx_DeleteMusicMem( int  MusicHandle);
		public static int  DeleteMusicMem( int  MusicHandle)
		{
			return dx_DeleteMusicMem( MusicHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadMusicMem")]
		extern static int  dx_LoadMusicMem( string  FileName);
		public static int  LoadMusicMem( string  FileName)
		{
			return dx_LoadMusicMem( FileName );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadMusicMemByMemImage")]
		extern unsafe static int  dx_LoadMusicMemByMemImage( void *  FileImageBuffer, int  FileImageSize);
		public unsafe static int  LoadMusicMemByMemImage( void *  FileImageBuffer, int  FileImageSize)
		{
			return dx_LoadMusicMemByMemImage( FileImageBuffer , FileImageSize );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_LoadMusicMemByResource")]
		extern static int  dx_LoadMusicMemByResource( string  ResourceName, string  ResourceType);
		public static int  LoadMusicMemByResource( string  ResourceName, string  ResourceType)
		{
			return dx_LoadMusicMemByResource( ResourceName , ResourceType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMusicMem")]
		extern static int  dx_PlayMusicMem( int  MusicHandle, int  PlayType);
		public static int  PlayMusicMem( int  MusicHandle, int  PlayType)
		{
			return dx_PlayMusicMem( MusicHandle , PlayType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopMusicMem")]
		extern static int  dx_StopMusicMem( int  MusicHandle);
		public static int  StopMusicMem( int  MusicHandle)
		{
			return dx_StopMusicMem( MusicHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMusicMem")]
		extern static int  dx_CheckMusicMem( int  MusicHandle);
		public static int  CheckMusicMem( int  MusicHandle)
		{
			return dx_CheckMusicMem( MusicHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMusicMemPosition")]
		extern static int  dx_GetMusicMemPosition( int  MusicHandle);
		public static int  GetMusicMemPosition( int  MusicHandle)
		{
			return dx_GetMusicMemPosition( MusicHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitMusicMem")]
		extern static int  dx_InitMusicMem( );
		public static int  InitMusicMem( )
		{
			return dx_InitMusicMem( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessMusicMem")]
		extern static int  dx_ProcessMusicMem( );
		public static int  ProcessMusicMem( )
		{
			return dx_ProcessMusicMem( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMusic")]
		extern static int  dx_PlayMusic( string  FileName, int  PlayType);
		public static int  PlayMusic( string  FileName, int  PlayType)
		{
			return dx_PlayMusic( FileName , PlayType );
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_PlayMusicByMemImage")]
		extern unsafe static int  dx_PlayMusicByMemImage( void *  FileImageBuffer, int  FileImageSize, int  PlayType);
		public unsafe static int  PlayMusicByMemImage( void *  FileImageBuffer, int  FileImageSize, int  PlayType)
		{
			return dx_PlayMusicByMemImage( FileImageBuffer , FileImageSize , PlayType );
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMusicByResource")]
		extern static int  dx_PlayMusicByResource( string  ResourceName, string  ResourceType, int  PlayType);
		public static int  PlayMusicByResource( string  ResourceName, string  ResourceType, int  PlayType)
		{
			return dx_PlayMusicByResource( ResourceName , ResourceType , PlayType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVolumeMusic")]
		extern static int  dx_SetVolumeMusic( int  Volume);
		public static int  SetVolumeMusic( int  Volume)
		{
			return dx_SetVolumeMusic( Volume );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopMusic")]
		extern static int  dx_StopMusic( );
		public static int  StopMusic( )
		{
			return dx_StopMusic( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMusic")]
		extern static int  dx_CheckMusic( );
		public static int  CheckMusic( )
		{
			return dx_CheckMusic( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMusicPosition")]
		extern static int  dx_GetMusicPosition( );
		public static int  GetMusicPosition( )
		{
			return dx_GetMusicPosition( );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SelectMidiMode")]
		extern static int  dx_SelectMidiMode( int  Mode);
		public static int  SelectMidiMode( int  Mode)
		{
			return dx_SelectMidiMode( Mode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DXArchivePreLoad")]
		extern static int  dx_DXArchivePreLoad( string  FilePath, int  ASync);
		public static int  DXArchivePreLoad( string  FilePath)
		{
			return dx_DXArchivePreLoad( FilePath , FALSE );
		}
		public static int  DXArchivePreLoad( string  FilePath, int  ASync)
		{
			return dx_DXArchivePreLoad( FilePath , ASync );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DXArchiveCheckIdle")]
		extern static int  dx_DXArchiveCheckIdle( string  FilePath);
		public static int  DXArchiveCheckIdle( string  FilePath)
		{
			return dx_DXArchiveCheckIdle( FilePath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DXArchiveRelease")]
		extern static int  dx_DXArchiveRelease( string  FilePath);
		public static int  DXArchiveRelease( string  FilePath)
		{
			return dx_DXArchiveRelease( FilePath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DXArchiveCheckFile")]
		extern static int  dx_DXArchiveCheckFile( string  FilePath, string  TargetFilePath);
		public static int  DXArchiveCheckFile( string  FilePath, string  TargetFilePath)
		{
			return dx_DXArchiveCheckFile( FilePath , TargetFilePath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1LoadModel")]
		extern static int  dx_MV1LoadModel( string  FileName);
		public static int  MV1LoadModel( string  FileName)
		{
			return dx_MV1LoadModel( FileName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DuplicateModel")]
		extern static int  dx_MV1DuplicateModel( int  SrcMHandle);
		public static int  MV1DuplicateModel( int  SrcMHandle)
		{
			return dx_MV1DuplicateModel( SrcMHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CreateCloneModel")]
		extern static int  dx_MV1CreateCloneModel( int  SrcMHandle);
		public static int  MV1CreateCloneModel( int  SrcMHandle)
		{
			return dx_MV1CreateCloneModel( SrcMHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DeleteModel")]
		extern static int  dx_MV1DeleteModel( int  MHandle);
		public static int  MV1DeleteModel( int  MHandle)
		{
			return dx_MV1DeleteModel( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelReMakeNormal")]
		extern static int  dx_MV1SetLoadModelReMakeNormal( int  Flag);
		public static int  MV1SetLoadModelReMakeNormal( int  Flag)
		{
			return dx_MV1SetLoadModelReMakeNormal( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelReMakeNormalSmoothingAngle")]
		extern static int  dx_MV1SetLoadModelReMakeNormalSmoothingAngle( float  SmoothingAngle);
		public static int  MV1SetLoadModelReMakeNormalSmoothingAngle( )
		{
			return dx_MV1SetLoadModelReMakeNormalSmoothingAngle( 1.562069f );
		}
		public static int  MV1SetLoadModelReMakeNormalSmoothingAngle( float  SmoothingAngle)
		{
			return dx_MV1SetLoadModelReMakeNormalSmoothingAngle( SmoothingAngle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelPositionOptimize")]
		extern static int  dx_MV1SetLoadModelPositionOptimize( int  Flag);
		public static int  MV1SetLoadModelPositionOptimize( int  Flag)
		{
			return dx_MV1SetLoadModelPositionOptimize( Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelUsePhysicsMode")]
		extern static int  dx_MV1SetLoadModelUsePhysicsMode( int  PhysicsMode);
		public static int  MV1SetLoadModelUsePhysicsMode( int  PhysicsMode)
		{
			return dx_MV1SetLoadModelUsePhysicsMode( PhysicsMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelPhysicsWorldGravity")]
		extern static int  dx_MV1SetLoadModelPhysicsWorldGravity( float  Gravity);
		public static int  MV1SetLoadModelPhysicsWorldGravity( float  Gravity)
		{
			return dx_MV1SetLoadModelPhysicsWorldGravity( Gravity );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DrawModel")]
		extern static int  dx_MV1DrawModel( int  MHandle);
		public static int  MV1DrawModel( int  MHandle)
		{
			return dx_MV1DrawModel( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DrawFrame")]
		extern static int  dx_MV1DrawFrame( int  MHandle, int  FrameIndex);
		public static int  MV1DrawFrame( int  MHandle, int  FrameIndex)
		{
			return dx_MV1DrawFrame( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DrawMesh")]
		extern static int  dx_MV1DrawMesh( int  MHandle, int  MeshIndex);
		public static int  MV1DrawMesh( int  MHandle, int  MeshIndex)
		{
			return dx_MV1DrawMesh( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DrawModelDebug")]
		extern static int  dx_MV1DrawModelDebug( int  MHandle, int  Color, int  IsNormalLine, float  NormalLineLength, int  IsPolyLine, int  IsCollisionBox);
		public static int  MV1DrawModelDebug( int  MHandle, int  Color, int  IsNormalLine, float  NormalLineLength, int  IsPolyLine, int  IsCollisionBox)
		{
			return dx_MV1DrawModelDebug( MHandle , Color , IsNormalLine , NormalLineLength , IsPolyLine , IsCollisionBox );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetLocalWorldMatrix")]
		extern static MATRIX  dx_MV1GetLocalWorldMatrix( int  MHandle);
		public static MATRIX  MV1GetLocalWorldMatrix( int  MHandle)
		{
			return dx_MV1GetLocalWorldMatrix( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetPosition")]
		extern static int  dx_MV1SetPosition( int  MHandle, VECTOR  Position);
		public static int  MV1SetPosition( int  MHandle, VECTOR  Position)
		{
			return dx_MV1SetPosition( MHandle , Position );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetPosition")]
		extern static VECTOR  dx_MV1GetPosition( int  MHandle);
		public static VECTOR  MV1GetPosition( int  MHandle)
		{
			return dx_MV1GetPosition( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetScale")]
		extern static int  dx_MV1SetScale( int  MHandle, VECTOR  Scale);
		public static int  MV1SetScale( int  MHandle, VECTOR  Scale)
		{
			return dx_MV1SetScale( MHandle , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetScale")]
		extern static VECTOR  dx_MV1GetScale( int  MHandle);
		public static VECTOR  MV1GetScale( int  MHandle)
		{
			return dx_MV1GetScale( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetRotationXYZ")]
		extern static int  dx_MV1SetRotationXYZ( int  MHandle, VECTOR  Rotate);
		public static int  MV1SetRotationXYZ( int  MHandle, VECTOR  Rotate)
		{
			return dx_MV1SetRotationXYZ( MHandle , Rotate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetRotationXYZ")]
		extern static VECTOR  dx_MV1GetRotationXYZ( int  MHandle);
		public static VECTOR  MV1GetRotationXYZ( int  MHandle)
		{
			return dx_MV1GetRotationXYZ( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetRotationZYAxis")]
		extern static int  dx_MV1SetRotationZYAxis( int  MHandle, VECTOR  ZAxisDirection, VECTOR  YAxisDirection, float  ZAxisTwistRotate);
		public static int  MV1SetRotationZYAxis( int  MHandle, VECTOR  ZAxisDirection, VECTOR  YAxisDirection, float  ZAxisTwistRotate)
		{
			return dx_MV1SetRotationZYAxis( MHandle , ZAxisDirection , YAxisDirection , ZAxisTwistRotate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetRotationMatrix")]
		extern static int  dx_MV1SetRotationMatrix( int  MHandle, MATRIX  Matrix);
		public static int  MV1SetRotationMatrix( int  MHandle, MATRIX  Matrix)
		{
			return dx_MV1SetRotationMatrix( MHandle , Matrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetRotationMatrix")]
		extern static MATRIX  dx_MV1GetRotationMatrix( int  MHandle);
		public static MATRIX  MV1GetRotationMatrix( int  MHandle)
		{
			return dx_MV1GetRotationMatrix( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMatrix")]
		extern static int  dx_MV1SetMatrix( int  MHandle, MATRIX  Matrix);
		public static int  MV1SetMatrix( int  MHandle, MATRIX  Matrix)
		{
			return dx_MV1SetMatrix( MHandle , Matrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMatrix")]
		extern static MATRIX  dx_MV1GetMatrix( int  MHandle);
		public static MATRIX  MV1GetMatrix( int  MHandle)
		{
			return dx_MV1GetMatrix( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetVisible")]
		extern static int  dx_MV1SetVisible( int  MHandle, int  VisibleFlag);
		public static int  MV1SetVisible( int  MHandle, int  VisibleFlag)
		{
			return dx_MV1SetVisible( MHandle , VisibleFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetVisible")]
		extern static int  dx_MV1GetVisible( int  MHandle);
		public static int  MV1GetVisible( int  MHandle)
		{
			return dx_MV1GetVisible( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetDifColorScale")]
		extern static int  dx_MV1SetDifColorScale( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetDifColorScale( int  MHandle, COLOR_F  Scale)
		{
			return dx_MV1SetDifColorScale( MHandle , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetDifColorScale")]
		extern static COLOR_F  dx_MV1GetDifColorScale( int  MHandle);
		public static COLOR_F  MV1GetDifColorScale( int  MHandle)
		{
			return dx_MV1GetDifColorScale( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetSpcColorScale")]
		extern static int  dx_MV1SetSpcColorScale( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetSpcColorScale( int  MHandle, COLOR_F  Scale)
		{
			return dx_MV1SetSpcColorScale( MHandle , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetSpcColorScale")]
		extern static COLOR_F  dx_MV1GetSpcColorScale( int  MHandle);
		public static COLOR_F  MV1GetSpcColorScale( int  MHandle)
		{
			return dx_MV1GetSpcColorScale( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetEmiColorScale")]
		extern static int  dx_MV1SetEmiColorScale( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetEmiColorScale( int  MHandle, COLOR_F  Scale)
		{
			return dx_MV1SetEmiColorScale( MHandle , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetEmiColorScale")]
		extern static COLOR_F  dx_MV1GetEmiColorScale( int  MHandle);
		public static COLOR_F  MV1GetEmiColorScale( int  MHandle)
		{
			return dx_MV1GetEmiColorScale( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAmbColorScale")]
		extern static int  dx_MV1SetAmbColorScale( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetAmbColorScale( int  MHandle, COLOR_F  Scale)
		{
			return dx_MV1SetAmbColorScale( MHandle , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAmbColorScale")]
		extern static COLOR_F  dx_MV1GetAmbColorScale( int  MHandle);
		public static COLOR_F  MV1GetAmbColorScale( int  MHandle)
		{
			return dx_MV1GetAmbColorScale( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetSemiTransState")]
		extern static int  dx_MV1GetSemiTransState( int  MHandle);
		public static int  MV1GetSemiTransState( int  MHandle)
		{
			return dx_MV1GetSemiTransState( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetOpacityRate")]
		extern static int  dx_MV1SetOpacityRate( int  MHandle, float  Rate);
		public static int  MV1SetOpacityRate( int  MHandle, float  Rate)
		{
			return dx_MV1SetOpacityRate( MHandle , Rate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetOpacityRate")]
		extern static float  dx_MV1GetOpacityRate( int  MHandle);
		public static float  MV1GetOpacityRate( int  MHandle)
		{
			return dx_MV1GetOpacityRate( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetUseZBuffer")]
		extern static int  dx_MV1SetUseZBuffer( int  MHandle, int  Flag);
		public static int  MV1SetUseZBuffer( int  MHandle, int  Flag)
		{
			return dx_MV1SetUseZBuffer( MHandle , Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetWriteZBuffer")]
		extern static int  dx_MV1SetWriteZBuffer( int  MHandle, int  Flag);
		public static int  MV1SetWriteZBuffer( int  MHandle, int  Flag)
		{
			return dx_MV1SetWriteZBuffer( MHandle , Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetZBufferCmpType")]
		extern static int  dx_MV1SetZBufferCmpType( int  MHandle, int  CmpType);
		public static int  MV1SetZBufferCmpType( int  MHandle, int  CmpType)
		{
			return dx_MV1SetZBufferCmpType( MHandle , CmpType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetZBias")]
		extern static int  dx_MV1SetZBias( int  MHandle, int  Bias);
		public static int  MV1SetZBias( int  MHandle, int  Bias)
		{
			return dx_MV1SetZBias( MHandle , Bias );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetUseVertDifColor")]
		extern static int  dx_MV1SetUseVertDifColor( int  MHandle, int  UseFlag);
		public static int  MV1SetUseVertDifColor( int  MHandle, int  UseFlag)
		{
			return dx_MV1SetUseVertDifColor( MHandle , UseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetUseVertSpcColor")]
		extern static int  dx_MV1SetUseVertSpcColor( int  MHandle, int  UseFlag);
		public static int  MV1SetUseVertSpcColor( int  MHandle, int  UseFlag)
		{
			return dx_MV1SetUseVertSpcColor( MHandle , UseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetSampleFilterMode")]
		extern static int  dx_MV1SetSampleFilterMode( int  MHandle, int  FilterMode);
		public static int  MV1SetSampleFilterMode( int  MHandle, int  FilterMode)
		{
			return dx_MV1SetSampleFilterMode( MHandle , FilterMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaxAnisotropy")]
		extern static int  dx_MV1SetMaxAnisotropy( int  MHandle, int  MaxAnisotropy);
		public static int  MV1SetMaxAnisotropy( int  MHandle, int  MaxAnisotropy)
		{
			return dx_MV1SetMaxAnisotropy( MHandle , MaxAnisotropy );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetWireFrameDrawFlag")]
		extern static int  dx_MV1SetWireFrameDrawFlag( int  MHandle, int  Flag);
		public static int  MV1SetWireFrameDrawFlag( int  MHandle, int  Flag)
		{
			return dx_MV1SetWireFrameDrawFlag( MHandle , Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1RefreshVertColorFromMaterial")]
		extern static int  dx_MV1RefreshVertColorFromMaterial( int  MHandle);
		public static int  MV1RefreshVertColorFromMaterial( int  MHandle)
		{
			return dx_MV1RefreshVertColorFromMaterial( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1PhysicsCalculation")]
		extern static int  dx_MV1PhysicsCalculation( int  MHandle, float  MillisecondTime);
		public static int  MV1PhysicsCalculation( int  MHandle, float  MillisecondTime)
		{
			return dx_MV1PhysicsCalculation( MHandle , MillisecondTime );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1PhysicsResetState")]
		extern static int  dx_MV1PhysicsResetState( int  MHandle);
		public static int  MV1PhysicsResetState( int  MHandle)
		{
			return dx_MV1PhysicsResetState( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1AttachAnim")]
		extern static int  dx_MV1AttachAnim( int  MHandle, int  AnimIndex, int  AnimSrcMHandle, int  NameCheck);
		public static int  MV1AttachAnim( int  MHandle, int  AnimIndex)
		{
			return dx_MV1AttachAnim( MHandle , AnimIndex , -1 , TRUE );
		}
		public static int  MV1AttachAnim( int  MHandle, int  AnimIndex, int  AnimSrcMHandle)
		{
			return dx_MV1AttachAnim( MHandle , AnimIndex , AnimSrcMHandle , TRUE );
		}
		public static int  MV1AttachAnim( int  MHandle, int  AnimIndex, int  AnimSrcMHandle, int  NameCheck)
		{
			return dx_MV1AttachAnim( MHandle , AnimIndex , AnimSrcMHandle , NameCheck );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DetachAnim")]
		extern static int  dx_MV1DetachAnim( int  MHandle, int  AttachIndex);
		public static int  MV1DetachAnim( int  MHandle, int  AttachIndex)
		{
			return dx_MV1DetachAnim( MHandle , AttachIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAttachAnimTime")]
		extern static int  dx_MV1SetAttachAnimTime( int  MHandle, int  AttachIndex, float  Time);
		public static int  MV1SetAttachAnimTime( int  MHandle, int  AttachIndex, float  Time)
		{
			return dx_MV1SetAttachAnimTime( MHandle , AttachIndex , Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnimTime")]
		extern static float  dx_MV1GetAttachAnimTime( int  MHandle, int  AttachIndex);
		public static float  MV1GetAttachAnimTime( int  MHandle, int  AttachIndex)
		{
			return dx_MV1GetAttachAnimTime( MHandle , AttachIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnimTotalTime")]
		extern static float  dx_MV1GetAttachAnimTotalTime( int  MHandle, int  AttachIndex);
		public static float  MV1GetAttachAnimTotalTime( int  MHandle, int  AttachIndex)
		{
			return dx_MV1GetAttachAnimTotalTime( MHandle , AttachIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAttachAnimBlendRate")]
		extern static int  dx_MV1SetAttachAnimBlendRate( int  MHandle, int  AttachIndex, float  Rate);
		public static int  MV1SetAttachAnimBlendRate( int  MHandle, int  AttachIndex)
		{
			return dx_MV1SetAttachAnimBlendRate( MHandle , AttachIndex , 1.0f );
		}
		public static int  MV1SetAttachAnimBlendRate( int  MHandle, int  AttachIndex, float  Rate)
		{
			return dx_MV1SetAttachAnimBlendRate( MHandle , AttachIndex , Rate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnimBlendRate")]
		extern static float  dx_MV1GetAttachAnimBlendRate( int  MHandle, int  AttachIndex);
		public static float  MV1GetAttachAnimBlendRate( int  MHandle, int  AttachIndex)
		{
			return dx_MV1GetAttachAnimBlendRate( MHandle , AttachIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAttachAnimBlendRateToFrame")]
		extern static int  dx_MV1SetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate, int  SetChild);
		public static int  MV1SetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate)
		{
			return dx_MV1SetAttachAnimBlendRateToFrame( MHandle , AttachIndex , FrameIndex , Rate , TRUE );
		}
		public static int  MV1SetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate, int  SetChild)
		{
			return dx_MV1SetAttachAnimBlendRateToFrame( MHandle , AttachIndex , FrameIndex , Rate , SetChild );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnimBlendRateToFrame")]
		extern static float  dx_MV1GetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex);
		public static float  MV1GetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex)
		{
			return dx_MV1GetAttachAnimBlendRateToFrame( MHandle , AttachIndex , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnim")]
		extern static int  dx_MV1GetAttachAnim( int  MHandle, int  AttachIndex);
		public static int  MV1GetAttachAnim( int  MHandle, int  AttachIndex)
		{
			return dx_MV1GetAttachAnim( MHandle , AttachIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimNum")]
		extern static int  dx_MV1GetAnimNum( int  MHandle);
		public static int  MV1GetAnimNum( int  MHandle)
		{
			return dx_MV1GetAnimNum( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimIndex")]
		extern static int  dx_MV1GetAnimIndex( int  MHandle, string  AnimName);
		public static int  MV1GetAnimIndex( int  MHandle, string  AnimName)
		{
			return dx_MV1GetAnimIndex( MHandle , AnimName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTotalTime")]
		extern static float  dx_MV1GetAnimTotalTime( int  MHandle, int  AnimIndex);
		public static float  MV1GetAnimTotalTime( int  MHandle, int  AnimIndex)
		{
			return dx_MV1GetAnimTotalTime( MHandle , AnimIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTargetFrameNum")]
		extern static int  dx_MV1GetAnimTargetFrameNum( int  MHandle, int  AnimIndex);
		public static int  MV1GetAnimTargetFrameNum( int  MHandle, int  AnimIndex)
		{
			return dx_MV1GetAnimTargetFrameNum( MHandle , AnimIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTargetFrame")]
		extern static int  dx_MV1GetAnimTargetFrame( int  MHandle, int  AnimIndex, int  AnimFrameIndex);
		public static int  MV1GetAnimTargetFrame( int  MHandle, int  AnimIndex, int  AnimFrameIndex)
		{
			return dx_MV1GetAnimTargetFrame( MHandle , AnimIndex , AnimFrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTargetFrameKeySetNum")]
		extern static int  dx_MV1GetAnimTargetFrameKeySetNum( int  MHandle, int  AnimIndex, int  AnimFrameIndex);
		public static int  MV1GetAnimTargetFrameKeySetNum( int  MHandle, int  AnimIndex, int  AnimFrameIndex)
		{
			return dx_MV1GetAnimTargetFrameKeySetNum( MHandle , AnimIndex , AnimFrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTargetFrameKeySet")]
		extern static int  dx_MV1GetAnimTargetFrameKeySet( int  MHandle, int  AnimIndex, int  AnimFrameIndex, int  Index);
		public static int  MV1GetAnimTargetFrameKeySet( int  MHandle, int  AnimIndex, int  AnimFrameIndex, int  Index)
		{
			return dx_MV1GetAnimTargetFrameKeySet( MHandle , AnimIndex , AnimFrameIndex , Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetNum")]
		extern static int  dx_MV1GetAnimKeySetNum( int  MHandle);
		public static int  MV1GetAnimKeySetNum( int  MHandle)
		{
			return dx_MV1GetAnimKeySetNum( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetType")]
		extern static int  dx_MV1GetAnimKeySetType( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetType( int  MHandle, int  AnimKeySetIndex)
		{
			return dx_MV1GetAnimKeySetType( MHandle , AnimKeySetIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetDataType")]
		extern static int  dx_MV1GetAnimKeySetDataType( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetDataType( int  MHandle, int  AnimKeySetIndex)
		{
			return dx_MV1GetAnimKeySetDataType( MHandle , AnimKeySetIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetTimeType")]
		extern static int  dx_MV1GetAnimKeySetTimeType( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetTimeType( int  MHandle, int  AnimKeySetIndex)
		{
			return dx_MV1GetAnimKeySetTimeType( MHandle , AnimKeySetIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetDataNum")]
		extern static int  dx_MV1GetAnimKeySetDataNum( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetDataNum( int  MHandle, int  AnimKeySetIndex)
		{
			return dx_MV1GetAnimKeySetDataNum( MHandle , AnimKeySetIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataTime")]
		extern static float  dx_MV1GetAnimKeyDataTime( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static float  MV1GetAnimKeyDataTime( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			return dx_MV1GetAnimKeyDataTime( MHandle , AnimKeySetIndex , Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToQuaternion")]
		extern static FLOAT4  dx_MV1GetAnimKeyDataToQuaternion( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static FLOAT4  MV1GetAnimKeyDataToQuaternion( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			return dx_MV1GetAnimKeyDataToQuaternion( MHandle , AnimKeySetIndex , Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToQuaternionFromTime")]
		extern static FLOAT4  dx_MV1GetAnimKeyDataToQuaternionFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static FLOAT4  MV1GetAnimKeyDataToQuaternionFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			return dx_MV1GetAnimKeyDataToQuaternionFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToVector")]
		extern static VECTOR  dx_MV1GetAnimKeyDataToVector( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static VECTOR  MV1GetAnimKeyDataToVector( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			return dx_MV1GetAnimKeyDataToVector( MHandle , AnimKeySetIndex , Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToVectorFromTime")]
		extern static VECTOR  dx_MV1GetAnimKeyDataToVectorFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static VECTOR  MV1GetAnimKeyDataToVectorFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			return dx_MV1GetAnimKeyDataToVectorFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToMatrix")]
		extern static MATRIX  dx_MV1GetAnimKeyDataToMatrix( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static MATRIX  MV1GetAnimKeyDataToMatrix( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			return dx_MV1GetAnimKeyDataToMatrix( MHandle , AnimKeySetIndex , Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToMatrixFromTime")]
		extern static MATRIX  dx_MV1GetAnimKeyDataToMatrixFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static MATRIX  MV1GetAnimKeyDataToMatrixFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			return dx_MV1GetAnimKeyDataToMatrixFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToFlat")]
		extern static float  dx_MV1GetAnimKeyDataToFlat( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static float  MV1GetAnimKeyDataToFlat( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			return dx_MV1GetAnimKeyDataToFlat( MHandle , AnimKeySetIndex , Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToFlatFromTime")]
		extern static float  dx_MV1GetAnimKeyDataToFlatFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static float  MV1GetAnimKeyDataToFlatFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			return dx_MV1GetAnimKeyDataToFlatFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToLinear")]
		extern static float  dx_MV1GetAnimKeyDataToLinear( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static float  MV1GetAnimKeyDataToLinear( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			return dx_MV1GetAnimKeyDataToLinear( MHandle , AnimKeySetIndex , Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToLinearFromTime")]
		extern static float  dx_MV1GetAnimKeyDataToLinearFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static float  MV1GetAnimKeyDataToLinearFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			return dx_MV1GetAnimKeyDataToLinearFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialNum")]
		extern static int  dx_MV1GetMaterialNum( int  MHandle);
		public static int  MV1GetMaterialNum( int  MHandle)
		{
			return dx_MV1GetMaterialNum( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialType")]
		extern static int  dx_MV1SetMaterialType( int  MHandle, int  MaterialIndex, int  Type);
		public static int  MV1SetMaterialType( int  MHandle, int  MaterialIndex, int  Type)
		{
			return dx_MV1SetMaterialType( MHandle , MaterialIndex , Type );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialType")]
		extern static int  dx_MV1GetMaterialType( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialType( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialType( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDifColor")]
		extern static int  dx_MV1SetMaterialDifColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialDifColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			return dx_MV1SetMaterialDifColor( MHandle , MaterialIndex , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDifColor")]
		extern static COLOR_F  dx_MV1GetMaterialDifColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialDifColor( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialDifColor( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcColor")]
		extern static int  dx_MV1SetMaterialSpcColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialSpcColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			return dx_MV1SetMaterialSpcColor( MHandle , MaterialIndex , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcColor")]
		extern static COLOR_F  dx_MV1GetMaterialSpcColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialSpcColor( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialSpcColor( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialEmiColor")]
		extern static int  dx_MV1SetMaterialEmiColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialEmiColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			return dx_MV1SetMaterialEmiColor( MHandle , MaterialIndex , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialEmiColor")]
		extern static COLOR_F  dx_MV1GetMaterialEmiColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialEmiColor( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialEmiColor( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialAmbColor")]
		extern static int  dx_MV1SetMaterialAmbColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialAmbColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			return dx_MV1SetMaterialAmbColor( MHandle , MaterialIndex , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialAmbColor")]
		extern static COLOR_F  dx_MV1GetMaterialAmbColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialAmbColor( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialAmbColor( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcPower")]
		extern static int  dx_MV1SetMaterialSpcPower( int  MHandle, int  MaterialIndex, float  Power);
		public static int  MV1SetMaterialSpcPower( int  MHandle, int  MaterialIndex, float  Power)
		{
			return dx_MV1SetMaterialSpcPower( MHandle , MaterialIndex , Power );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcPower")]
		extern static float  dx_MV1GetMaterialSpcPower( int  MHandle, int  MaterialIndex);
		public static float  MV1GetMaterialSpcPower( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialSpcPower( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDifMapTexture")]
		extern static int  dx_MV1SetMaterialDifMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialDifMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
			return dx_MV1SetMaterialDifMapTexture( MHandle , MaterialIndex , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDifMapTexture")]
		extern static int  dx_MV1GetMaterialDifMapTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDifMapTexture( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialDifMapTexture( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcMapTexture")]
		extern static int  dx_MV1SetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
			return dx_MV1SetMaterialSpcMapTexture( MHandle , MaterialIndex , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcMapTexture")]
		extern static int  dx_MV1GetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialSpcMapTexture( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialNormalMapTexture")]
		extern static int  dx_MV1GetMaterialNormalMapTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialNormalMapTexture( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialNormalMapTexture( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDifGradTexture")]
		extern static int  dx_MV1SetMaterialDifGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialDifGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
			return dx_MV1SetMaterialDifGradTexture( MHandle , MaterialIndex , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDifGradTexture")]
		extern static int  dx_MV1GetMaterialDifGradTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDifGradTexture( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialDifGradTexture( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcGradTexture")]
		extern static int  dx_MV1SetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
			return dx_MV1SetMaterialSpcGradTexture( MHandle , MaterialIndex , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcGradTexture")]
		extern static int  dx_MV1GetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialSpcGradTexture( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDifGradBlendType")]
		extern static int  dx_MV1SetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType);
		public static int  MV1SetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType)
		{
			return dx_MV1SetMaterialDifGradBlendType( MHandle , MaterialIndex , BlendType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDifGradBlendType")]
		extern static int  dx_MV1GetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialDifGradBlendType( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcGradBlendType")]
		extern static int  dx_MV1SetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType);
		public static int  MV1SetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType)
		{
			return dx_MV1SetMaterialSpcGradBlendType( MHandle , MaterialIndex , BlendType );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcGradBlendType")]
		extern static int  dx_MV1GetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialSpcGradBlendType( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialOutLineWidth")]
		extern static int  dx_MV1SetMaterialOutLineWidth( int  MHandle, int  MaterialIndex, float  Width);
		public static int  MV1SetMaterialOutLineWidth( int  MHandle, int  MaterialIndex, float  Width)
		{
			return dx_MV1SetMaterialOutLineWidth( MHandle , MaterialIndex , Width );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialOutLineWidth")]
		extern static float  dx_MV1GetMaterialOutLineWidth( int  MHandle, int  MaterialIndex);
		public static float  MV1GetMaterialOutLineWidth( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialOutLineWidth( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialOutLineDotWidth")]
		extern static int  dx_MV1SetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex, float  Width);
		public static int  MV1SetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex, float  Width)
		{
			return dx_MV1SetMaterialOutLineDotWidth( MHandle , MaterialIndex , Width );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialOutLineDotWidth")]
		extern static float  dx_MV1GetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex);
		public static float  MV1GetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialOutLineDotWidth( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialOutLineColor")]
		extern static int  dx_MV1SetMaterialOutLineColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialOutLineColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			return dx_MV1SetMaterialOutLineColor( MHandle , MaterialIndex , Color );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialOutLineColor")]
		extern static COLOR_F  dx_MV1GetMaterialOutLineColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialOutLineColor( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialOutLineColor( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDrawBlendMode")]
		extern static int  dx_MV1SetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex, int  BlendMode);
		public static int  MV1SetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex, int  BlendMode)
		{
			return dx_MV1SetMaterialDrawBlendMode( MHandle , MaterialIndex , BlendMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDrawBlendMode")]
		extern static int  dx_MV1GetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialDrawBlendMode( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDrawBlendParam")]
		extern static int  dx_MV1SetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex, int  BlendParam);
		public static int  MV1SetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex, int  BlendParam)
		{
			return dx_MV1SetMaterialDrawBlendParam( MHandle , MaterialIndex , BlendParam );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDrawBlendParam")]
		extern static int  dx_MV1GetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex)
		{
			return dx_MV1GetMaterialDrawBlendParam( MHandle , MaterialIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureNum")]
		extern static int  dx_MV1GetTextureNum( int  MHandle);
		public static int  MV1GetTextureNum( int  MHandle)
		{
			return dx_MV1GetTextureNum( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureColorFilePath")]
		extern static int  dx_MV1SetTextureColorFilePath( int  MHandle, int  TexIndex, string  FilePath);
		public static int  MV1SetTextureColorFilePath( int  MHandle, int  TexIndex, string  FilePath)
		{
			return dx_MV1SetTextureColorFilePath( MHandle , TexIndex , FilePath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureAlphaFilePath")]
		extern static int  dx_MV1SetTextureAlphaFilePath( int  MHandle, int  TexIndex, string  FilePath);
		public static int  MV1SetTextureAlphaFilePath( int  MHandle, int  TexIndex, string  FilePath)
		{
			return dx_MV1SetTextureAlphaFilePath( MHandle , TexIndex , FilePath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureGraphHandle")]
		extern static int  dx_MV1SetTextureGraphHandle( int  MHandle, int  TexIndex, int  GrHandle, int  SemiTransFlag);
		public static int  MV1SetTextureGraphHandle( int  MHandle, int  TexIndex, int  GrHandle, int  SemiTransFlag)
		{
			return dx_MV1SetTextureGraphHandle( MHandle , TexIndex , GrHandle , SemiTransFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureGraphHandle")]
		extern static int  dx_MV1GetTextureGraphHandle( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureGraphHandle( int  MHandle, int  TexIndex)
		{
			return dx_MV1GetTextureGraphHandle( MHandle , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureAddressMode")]
		extern static int  dx_MV1SetTextureAddressMode( int  MHandle, int  TexIndex, int  AddrUMode, int  AddrVMode);
		public static int  MV1SetTextureAddressMode( int  MHandle, int  TexIndex, int  AddrUMode, int  AddrVMode)
		{
			return dx_MV1SetTextureAddressMode( MHandle , TexIndex , AddrUMode , AddrVMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureAddressModeU")]
		extern static int  dx_MV1GetTextureAddressModeU( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureAddressModeU( int  MHandle, int  TexIndex)
		{
			return dx_MV1GetTextureAddressModeU( MHandle , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureAddressModeV")]
		extern static int  dx_MV1GetTextureAddressModeV( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureAddressModeV( int  MHandle, int  TexIndex)
		{
			return dx_MV1GetTextureAddressModeV( MHandle , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureWidth")]
		extern static int  dx_MV1GetTextureWidth( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureWidth( int  MHandle, int  TexIndex)
		{
			return dx_MV1GetTextureWidth( MHandle , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureHeight")]
		extern static int  dx_MV1GetTextureHeight( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureHeight( int  MHandle, int  TexIndex)
		{
			return dx_MV1GetTextureHeight( MHandle , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureSemiTransState")]
		extern static int  dx_MV1GetTextureSemiTransState( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureSemiTransState( int  MHandle, int  TexIndex)
		{
			return dx_MV1GetTextureSemiTransState( MHandle , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureBumpImageFlag")]
		extern static int  dx_MV1SetTextureBumpImageFlag( int  MHandle, int  TexIndex, int  Flag);
		public static int  MV1SetTextureBumpImageFlag( int  MHandle, int  TexIndex, int  Flag)
		{
			return dx_MV1SetTextureBumpImageFlag( MHandle , TexIndex , Flag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureBumpImageFlag")]
		extern static int  dx_MV1GetTextureBumpImageFlag( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureBumpImageFlag( int  MHandle, int  TexIndex)
		{
			return dx_MV1GetTextureBumpImageFlag( MHandle , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureBumpImageNextPixelLength")]
		extern static int  dx_MV1SetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex, float  Length);
		public static int  MV1SetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex, float  Length)
		{
			return dx_MV1SetTextureBumpImageNextPixelLength( MHandle , TexIndex , Length );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureBumpImageNextPixelLength")]
		extern static float  dx_MV1GetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex);
		public static float  MV1GetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex)
		{
			return dx_MV1GetTextureBumpImageNextPixelLength( MHandle , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureSampleFilterMode")]
		extern static int  dx_MV1SetTextureSampleFilterMode( int  MHandle, int  TexIndex, int  FilterMode);
		public static int  MV1SetTextureSampleFilterMode( int  MHandle, int  TexIndex, int  FilterMode)
		{
			return dx_MV1SetTextureSampleFilterMode( MHandle , TexIndex , FilterMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureSampleFilterMode")]
		extern static int  dx_MV1GetTextureSampleFilterMode( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureSampleFilterMode( int  MHandle, int  TexIndex)
		{
			return dx_MV1GetTextureSampleFilterMode( MHandle , TexIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1LoadTexture")]
		extern static int  dx_MV1LoadTexture( string  FilePath);
		public static int  MV1LoadTexture( string  FilePath)
		{
			return dx_MV1LoadTexture( FilePath );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameNum")]
		extern static int  dx_MV1GetFrameNum( int  MHandle);
		public static int  MV1GetFrameNum( int  MHandle)
		{
			return dx_MV1GetFrameNum( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SearchFrame")]
		extern static int  dx_MV1SearchFrame( int  MHandle, string  FrameName);
		public static int  MV1SearchFrame( int  MHandle, string  FrameName)
		{
			return dx_MV1SearchFrame( MHandle , FrameName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SearchFrameChild")]
		extern static int  dx_MV1SearchFrameChild( int  MHandle, int  FrameIndex, string  ChildName);
		public static int  MV1SearchFrameChild( int  MHandle)
		{
			return dx_MV1SearchFrameChild( MHandle , -1 , null );
		}
		public static int  MV1SearchFrameChild( int  MHandle, int  FrameIndex)
		{
			return dx_MV1SearchFrameChild( MHandle , FrameIndex , null );
		}
		public static int  MV1SearchFrameChild( int  MHandle, int  FrameIndex, string  ChildName)
		{
			return dx_MV1SearchFrameChild( MHandle , FrameIndex , ChildName );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameParent")]
		extern static int  dx_MV1GetFrameParent( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameParent( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameParent( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameChildNum")]
		extern static int  dx_MV1GetFrameChildNum( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameChildNum( int  MHandle)
		{
			return dx_MV1GetFrameChildNum( MHandle , -1 );
		}
		public static int  MV1GetFrameChildNum( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameChildNum( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameChild")]
		extern static int  dx_MV1GetFrameChild( int  MHandle, int  FrameIndex, int  ChildIndex);
		public static int  MV1GetFrameChild( int  MHandle)
		{
			return dx_MV1GetFrameChild( MHandle , -1 , 0 );
		}
		public static int  MV1GetFrameChild( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameChild( MHandle , FrameIndex , 0 );
		}
		public static int  MV1GetFrameChild( int  MHandle, int  FrameIndex, int  ChildIndex)
		{
			return dx_MV1GetFrameChild( MHandle , FrameIndex , ChildIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFramePosition")]
		extern static VECTOR  dx_MV1GetFramePosition( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFramePosition( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFramePosition( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameBaseLocalMatrix")]
		extern static MATRIX  dx_MV1GetFrameBaseLocalMatrix( int  MHandle, int  FrameIndex);
		public static MATRIX  MV1GetFrameBaseLocalMatrix( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameBaseLocalMatrix( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameLocalMatrix")]
		extern static MATRIX  dx_MV1GetFrameLocalMatrix( int  MHandle, int  FrameIndex);
		public static MATRIX  MV1GetFrameLocalMatrix( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameLocalMatrix( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameLocalWorldMatrix")]
		extern static MATRIX  dx_MV1GetFrameLocalWorldMatrix( int  MHandle, int  FrameIndex);
		public static MATRIX  MV1GetFrameLocalWorldMatrix( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameLocalWorldMatrix( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameUserLocalMatrix")]
		extern static int  dx_MV1SetFrameUserLocalMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix);
		public static int  MV1SetFrameUserLocalMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix)
		{
			return dx_MV1SetFrameUserLocalMatrix( MHandle , FrameIndex , Matrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1ResetFrameUserLocalMatrix")]
		extern static int  dx_MV1ResetFrameUserLocalMatrix( int  MHandle, int  FrameIndex);
		public static int  MV1ResetFrameUserLocalMatrix( int  MHandle, int  FrameIndex)
		{
			return dx_MV1ResetFrameUserLocalMatrix( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameMaxVertexLocalPosition")]
		extern static VECTOR  dx_MV1GetFrameMaxVertexLocalPosition( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFrameMaxVertexLocalPosition( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameMaxVertexLocalPosition( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameMinVertexLocalPosition")]
		extern static VECTOR  dx_MV1GetFrameMinVertexLocalPosition( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFrameMinVertexLocalPosition( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameMinVertexLocalPosition( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameAvgVertexLocalPosition")]
		extern static VECTOR  dx_MV1GetFrameAvgVertexLocalPosition( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFrameAvgVertexLocalPosition( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameAvgVertexLocalPosition( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameTriangleNum")]
		extern static int  dx_MV1GetFrameTriangleNum( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameTriangleNum( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameTriangleNum( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameMeshNum")]
		extern static int  dx_MV1GetFrameMeshNum( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameMeshNum( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameMeshNum( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameMesh")]
		extern static int  dx_MV1GetFrameMesh( int  MHandle, int  FrameIndex, int  Index);
		public static int  MV1GetFrameMesh( int  MHandle, int  FrameIndex, int  Index)
		{
			return dx_MV1GetFrameMesh( MHandle , FrameIndex , Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameVisible")]
		extern static int  dx_MV1SetFrameVisible( int  MHandle, int  FrameIndex, int  VisibleFlag);
		public static int  MV1SetFrameVisible( int  MHandle, int  FrameIndex, int  VisibleFlag)
		{
			return dx_MV1SetFrameVisible( MHandle , FrameIndex , VisibleFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameVisible")]
		extern static int  dx_MV1GetFrameVisible( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameVisible( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameVisible( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameDifColorScale")]
		extern static int  dx_MV1SetFrameDifColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameDifColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
			return dx_MV1SetFrameDifColorScale( MHandle , FrameIndex , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameSpcColorScale")]
		extern static int  dx_MV1SetFrameSpcColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameSpcColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
			return dx_MV1SetFrameSpcColorScale( MHandle , FrameIndex , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameEmiColorScale")]
		extern static int  dx_MV1SetFrameEmiColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameEmiColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
			return dx_MV1SetFrameEmiColorScale( MHandle , FrameIndex , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameAmbColorScale")]
		extern static int  dx_MV1SetFrameAmbColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameAmbColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
			return dx_MV1SetFrameAmbColorScale( MHandle , FrameIndex , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameDifColorScale")]
		extern static COLOR_F  dx_MV1GetFrameDifColorScale( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameDifColorScale( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameDifColorScale( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameSpcColorScale")]
		extern static COLOR_F  dx_MV1GetFrameSpcColorScale( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameSpcColorScale( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameSpcColorScale( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameEmiColorScale")]
		extern static COLOR_F  dx_MV1GetFrameEmiColorScale( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameEmiColorScale( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameEmiColorScale( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameAmbColorScale")]
		extern static COLOR_F  dx_MV1GetFrameAmbColorScale( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameAmbColorScale( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameAmbColorScale( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameSemiTransState")]
		extern static int  dx_MV1GetFrameSemiTransState( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameSemiTransState( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameSemiTransState( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameOpacityRate")]
		extern static int  dx_MV1SetFrameOpacityRate( int  MHandle, int  FrameIndex, float  Rate);
		public static int  MV1SetFrameOpacityRate( int  MHandle, int  FrameIndex, float  Rate)
		{
			return dx_MV1SetFrameOpacityRate( MHandle , FrameIndex , Rate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameOpacityRate")]
		extern static float  dx_MV1GetFrameOpacityRate( int  MHandle, int  FrameIndex);
		public static float  MV1GetFrameOpacityRate( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameOpacityRate( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameBaseVisible")]
		extern static int  dx_MV1SetFrameBaseVisible( int  MHandle, int  FrameIndex, int  VisibleFlag);
		public static int  MV1SetFrameBaseVisible( int  MHandle, int  FrameIndex, int  VisibleFlag)
		{
			return dx_MV1SetFrameBaseVisible( MHandle , FrameIndex , VisibleFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameBaseVisible")]
		extern static int  dx_MV1GetFrameBaseVisible( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameBaseVisible( int  MHandle, int  FrameIndex)
		{
			return dx_MV1GetFrameBaseVisible( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameTextureAddressTransform")]
		extern static int  dx_MV1SetFrameTextureAddressTransform( int  MHandle, int  FrameIndex, float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate);
		public static int  MV1SetFrameTextureAddressTransform( int  MHandle, int  FrameIndex, float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate)
		{
			return dx_MV1SetFrameTextureAddressTransform( MHandle , FrameIndex , TransU , TransV , ScaleU , ScaleV , RotCenterU , RotCenterV , Rotate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameTextureAddressTransformMatrix")]
		extern static int  dx_MV1SetFrameTextureAddressTransformMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix);
		public static int  MV1SetFrameTextureAddressTransformMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix)
		{
			return dx_MV1SetFrameTextureAddressTransformMatrix( MHandle , FrameIndex , Matrix );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1ResetFrameTextureAddressTransform")]
		extern static int  dx_MV1ResetFrameTextureAddressTransform( int  MHandle, int  FrameIndex);
		public static int  MV1ResetFrameTextureAddressTransform( int  MHandle, int  FrameIndex)
		{
			return dx_MV1ResetFrameTextureAddressTransform( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshNum")]
		extern static int  dx_MV1GetMeshNum( int  MHandle);
		public static int  MV1GetMeshNum( int  MHandle)
		{
			return dx_MV1GetMeshNum( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshMaterial")]
		extern static int  dx_MV1GetMeshMaterial( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshMaterial( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshMaterial( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshTriangleNum")]
		extern static int  dx_MV1GetMeshTriangleNum( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshTriangleNum( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshTriangleNum( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshVisible")]
		extern static int  dx_MV1SetMeshVisible( int  MHandle, int  MeshIndex, int  VisibleFlag);
		public static int  MV1SetMeshVisible( int  MHandle, int  MeshIndex, int  VisibleFlag)
		{
			return dx_MV1SetMeshVisible( MHandle , MeshIndex , VisibleFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshVisible")]
		extern static int  dx_MV1GetMeshVisible( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshVisible( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshVisible( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshDifColorScale")]
		extern static int  dx_MV1SetMeshDifColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshDifColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
			return dx_MV1SetMeshDifColorScale( MHandle , MeshIndex , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshSpcColorScale")]
		extern static int  dx_MV1SetMeshSpcColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshSpcColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
			return dx_MV1SetMeshSpcColorScale( MHandle , MeshIndex , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshEmiColorScale")]
		extern static int  dx_MV1SetMeshEmiColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshEmiColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
			return dx_MV1SetMeshEmiColorScale( MHandle , MeshIndex , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshAmbColorScale")]
		extern static int  dx_MV1SetMeshAmbColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshAmbColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
			return dx_MV1SetMeshAmbColorScale( MHandle , MeshIndex , Scale );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshDifColorScale")]
		extern static COLOR_F  dx_MV1GetMeshDifColorScale( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshDifColorScale( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshDifColorScale( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshSpcColorScale")]
		extern static COLOR_F  dx_MV1GetMeshSpcColorScale( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshSpcColorScale( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshSpcColorScale( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshEmiColorScale")]
		extern static COLOR_F  dx_MV1GetMeshEmiColorScale( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshEmiColorScale( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshEmiColorScale( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshAmbColorScale")]
		extern static COLOR_F  dx_MV1GetMeshAmbColorScale( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshAmbColorScale( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshAmbColorScale( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshOpacityRate")]
		extern static int  dx_MV1SetMeshOpacityRate( int  MHandle, int  MeshIndex, float  Rate);
		public static int  MV1SetMeshOpacityRate( int  MHandle, int  MeshIndex, float  Rate)
		{
			return dx_MV1SetMeshOpacityRate( MHandle , MeshIndex , Rate );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshOpacityRate")]
		extern static float  dx_MV1GetMeshOpacityRate( int  MHandle, int  MeshIndex);
		public static float  MV1GetMeshOpacityRate( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshOpacityRate( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshDrawBlendMode")]
		extern static int  dx_MV1SetMeshDrawBlendMode( int  MHandle, int  MeshIndex, int  BlendMode);
		public static int  MV1SetMeshDrawBlendMode( int  MHandle, int  MeshIndex, int  BlendMode)
		{
			return dx_MV1SetMeshDrawBlendMode( MHandle , MeshIndex , BlendMode );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshDrawBlendParam")]
		extern static int  dx_MV1SetMeshDrawBlendParam( int  MHandle, int  MeshIndex, int  BlendParam);
		public static int  MV1SetMeshDrawBlendParam( int  MHandle, int  MeshIndex, int  BlendParam)
		{
			return dx_MV1SetMeshDrawBlendParam( MHandle , MeshIndex , BlendParam );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshDrawBlendMode")]
		extern static int  dx_MV1GetMeshDrawBlendMode( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshDrawBlendMode( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshDrawBlendMode( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshDrawBlendParam")]
		extern static int  dx_MV1GetMeshDrawBlendParam( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshDrawBlendParam( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshDrawBlendParam( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshBaseVisible")]
		extern static int  dx_MV1SetMeshBaseVisible( int  MHandle, int  MeshIndex, int  VisibleFlag);
		public static int  MV1SetMeshBaseVisible( int  MHandle, int  MeshIndex, int  VisibleFlag)
		{
			return dx_MV1SetMeshBaseVisible( MHandle , MeshIndex , VisibleFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshBaseVisible")]
		extern static int  dx_MV1GetMeshBaseVisible( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshBaseVisible( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshBaseVisible( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshBackCulling")]
		extern static int  dx_MV1SetMeshBackCulling( int  MHandle, int  MeshIndex, int  CullingFlag);
		public static int  MV1SetMeshBackCulling( int  MHandle, int  MeshIndex, int  CullingFlag)
		{
			return dx_MV1SetMeshBackCulling( MHandle , MeshIndex , CullingFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshBackCulling")]
		extern static int  dx_MV1GetMeshBackCulling( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshBackCulling( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshBackCulling( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshMaxPosition")]
		extern static VECTOR  dx_MV1GetMeshMaxPosition( int  MHandle, int  MeshIndex);
		public static VECTOR  MV1GetMeshMaxPosition( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshMaxPosition( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshMinPosition")]
		extern static VECTOR  dx_MV1GetMeshMinPosition( int  MHandle, int  MeshIndex);
		public static VECTOR  MV1GetMeshMinPosition( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshMinPosition( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshTListNum")]
		extern static int  dx_MV1GetMeshTListNum( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshTListNum( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshTListNum( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshTList")]
		extern static int  dx_MV1GetMeshTList( int  MHandle, int  MeshIndex, int  Index);
		public static int  MV1GetMeshTList( int  MHandle, int  MeshIndex, int  Index)
		{
			return dx_MV1GetMeshTList( MHandle , MeshIndex , Index );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshSemiTransState")]
		extern static int  dx_MV1GetMeshSemiTransState( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshSemiTransState( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshSemiTransState( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshUseVertDifColor")]
		extern static int  dx_MV1SetMeshUseVertDifColor( int  MHandle, int  MeshIndex, int  UseFlag);
		public static int  MV1SetMeshUseVertDifColor( int  MHandle, int  MeshIndex, int  UseFlag)
		{
			return dx_MV1SetMeshUseVertDifColor( MHandle , MeshIndex , UseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshUseVertSpcColor")]
		extern static int  dx_MV1SetMeshUseVertSpcColor( int  MHandle, int  MeshIndex, int  UseFlag);
		public static int  MV1SetMeshUseVertSpcColor( int  MHandle, int  MeshIndex, int  UseFlag)
		{
			return dx_MV1SetMeshUseVertSpcColor( MHandle , MeshIndex , UseFlag );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshUseVertDifColor")]
		extern static int  dx_MV1GetMeshUseVertDifColor( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshUseVertDifColor( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshUseVertDifColor( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshUseVertSpcColor")]
		extern static int  dx_MV1GetMeshUseVertSpcColor( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshUseVertSpcColor( int  MHandle, int  MeshIndex)
		{
			return dx_MV1GetMeshUseVertSpcColor( MHandle , MeshIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTriangleListNum")]
		extern static int  dx_MV1GetTriangleListNum( int  MHandle);
		public static int  MV1GetTriangleListNum( int  MHandle)
		{
			return dx_MV1GetTriangleListNum( MHandle );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTriangleListVertexType")]
		extern static int  dx_MV1GetTriangleListVertexType( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListVertexType( int  MHandle, int  TListIndex)
		{
			return dx_MV1GetTriangleListVertexType( MHandle , TListIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTriangleListPolygonNum")]
		extern static int  dx_MV1GetTriangleListPolygonNum( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListPolygonNum( int  MHandle, int  TListIndex)
		{
			return dx_MV1GetTriangleListPolygonNum( MHandle , TListIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTriangleListVertexNum")]
		extern static int  dx_MV1GetTriangleListVertexNum( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListVertexNum( int  MHandle, int  TListIndex)
		{
			return dx_MV1GetTriangleListVertexNum( MHandle , TListIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetupCollInfo")]
		extern static int  dx_MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum, int  ZDivNum);
		public static int  MV1SetupCollInfo( int  MHandle)
		{
			return dx_MV1SetupCollInfo( MHandle , -1 , 32 , 8 , 32 );
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex)
		{
			return dx_MV1SetupCollInfo( MHandle , FrameIndex , 32 , 8 , 32 );
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum)
		{
			return dx_MV1SetupCollInfo( MHandle , FrameIndex , XDivNum , 8 , 32 );
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum)
		{
			return dx_MV1SetupCollInfo( MHandle , FrameIndex , XDivNum , YDivNum , 32 );
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum, int  ZDivNum)
		{
			return dx_MV1SetupCollInfo( MHandle , FrameIndex , XDivNum , YDivNum , ZDivNum );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1TerminateCollInfo")]
		extern static int  dx_MV1TerminateCollInfo( int  MHandle, int  FrameIndex);
		public static int  MV1TerminateCollInfo( int  MHandle)
		{
			return dx_MV1TerminateCollInfo( MHandle , -1 );
		}
		public static int  MV1TerminateCollInfo( int  MHandle, int  FrameIndex)
		{
			return dx_MV1TerminateCollInfo( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1RefreshCollInfo")]
		extern static int  dx_MV1RefreshCollInfo( int  MHandle, int  FrameIndex);
		public static int  MV1RefreshCollInfo( int  MHandle)
		{
			return dx_MV1RefreshCollInfo( MHandle , -1 );
		}
		public static int  MV1RefreshCollInfo( int  MHandle, int  FrameIndex)
		{
			return dx_MV1RefreshCollInfo( MHandle , FrameIndex );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_Line")]
		extern static MV1_COLL_RESULT_POLY  dx_MV1CollCheck_Line( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd);
		public static MV1_COLL_RESULT_POLY  MV1CollCheck_Line( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd)
		{
			return dx_MV1CollCheck_Line( MHandle , FrameIndex , PosStart , PosEnd );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_LineDim")]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_LineDim( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_LineDim( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd)
		{
			return dx_MV1CollCheck_LineDim( MHandle , FrameIndex , PosStart , PosEnd );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_Sphere")]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_Sphere( int  MHandle, int  FrameIndex, VECTOR  CenterPos, float  r);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Sphere( int  MHandle, int  FrameIndex, VECTOR  CenterPos, float  r)
		{
			return dx_MV1CollCheck_Sphere( MHandle , FrameIndex , CenterPos , r );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_Capsule")]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_Capsule( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, float  r);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Capsule( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, float  r)
		{
			return dx_MV1CollCheck_Capsule( MHandle , FrameIndex , Pos1 , Pos2 , r );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_GetResultPoly")]
		extern static MV1_COLL_RESULT_POLY  dx_MV1CollCheck_GetResultPoly( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim, int  PolyNo);
		public static MV1_COLL_RESULT_POLY  MV1CollCheck_GetResultPoly( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim, int  PolyNo)
		{
			return dx_MV1CollCheck_GetResultPoly( ResultPolyDim , PolyNo );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollResultPolyDimTerminate")]
		extern static int  dx_MV1CollResultPolyDimTerminate( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim);
		public static int  MV1CollResultPolyDimTerminate( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim)
		{
			return dx_MV1CollResultPolyDimTerminate( ResultPolyDim );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetupReferenceMesh")]
		extern static int  dx_MV1SetupReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform);
		public static int  MV1SetupReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform)
		{
			return dx_MV1SetupReferenceMesh( MHandle , FrameIndex , IsTransform );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1TerminateReferenceMesh")]
		extern static int  dx_MV1TerminateReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform);
		public static int  MV1TerminateReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform)
		{
			return dx_MV1TerminateReferenceMesh( MHandle , FrameIndex , IsTransform );
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1RefreshReferenceMesh")]
		extern static int  dx_MV1RefreshReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform);
		public static int  MV1RefreshReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform)
		{
			return dx_MV1RefreshReferenceMesh( MHandle , FrameIndex , IsTransform );
		}



	}
}
