// ���� ifdef ���Ǵ���ʹ�� DLL �������򵥵�
// ��ı�׼�������� DLL �е������ļ��������������϶���� CCGTSCLOUDOILPAINTERCRYPT_EXPORTS
// ���ű���ġ���ʹ�ô� DLL ��
// �κ�������Ŀ�ϲ�Ӧ����˷��š�������Դ�ļ��а������ļ����κ�������Ŀ���Ὣ
// CCGTSCLOUDOILPAINTERCRYPT_API ������Ϊ�Ǵ� DLL ����ģ����� DLL ���ô˺궨���
// ������Ϊ�Ǳ������ġ�
#ifdef CCGTSCLOUDOILPAINTERCRYPT_EXPORTS
#define CCGTSCLOUDOILPAINTERCRYPT_API __declspec(dllexport)
#else
#define CCGTSCLOUDOILPAINTERCRYPT_API __declspec(dllimport)
#endif

// �����Ǵ� cc.gtscloud.oilpainter.crypt.dll ������
class CCGTSCLOUDOILPAINTERCRYPT_API Cccgtscloudoilpaintercrypt {
public:
	Cccgtscloudoilpaintercrypt(void);
	// TODO:  �ڴ�������ķ�����
};

extern CCGTSCLOUDOILPAINTERCRYPT_API int nccgtscloudoilpaintercrypt;

CCGTSCLOUDOILPAINTERCRYPT_API int fnccgtscloudoilpaintercrypt(void);
