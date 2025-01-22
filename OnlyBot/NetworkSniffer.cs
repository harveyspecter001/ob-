using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using OnlyBot.Forms;
using OnlyBot.Sniffer.Protocol;
using PacketDotNet;
using SharpPcap;

namespace OnlyBot
{
	// Token: 0x02000E9B RID: 3739
	[Nullable(0)]
	[NullableContext(1)]
	public class NetworkSniffer
	{
		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x0600B22F RID: 45615 RVA: 0x002A2D18 File Offset: 0x002A0F18
		public bool IsRunning
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x0600B230 RID: 45616 RVA: 0x002A2D20 File Offset: 0x002A0F20
		public bool IsPaused
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x002A2D28 File Offset: 0x002A0F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NetworkSniffer(SnifferForm form, int pid)
		{
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x002A2D38 File Offset: 0x002A0F38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartCapture(ICaptureDevice selectedDevice)
		{
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x002A2D48 File Offset: 0x002A0F48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopCapture()
		{
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x002A2D58 File Offset: 0x002A0F58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PauseCapture()
		{
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x002A2D68 File Offset: 0x002A0F68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResumeCapture()
		{
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x002A2D78 File Offset: 0x002A0F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CapturePackets(ICaptureDevice selectedDevice)
		{
		}

		// Token: 0x0600B237 RID: 45623 RVA: 0x002A2D88 File Offset: 0x002A0F88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PacketHandler(object sender, PacketCapture e)
		{
		}

		// Token: 0x0600B238 RID: 45624 RVA: 0x002A2D98 File Offset: 0x002A0F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleIPv4Packet(IPv4Packet ipPacket)
		{
		}

		// Token: 0x0600B239 RID: 45625 RVA: 0x002A2DA8 File Offset: 0x002A0FA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleDofusPacket(IPv4Packet ipPacket, TcpPacket tcpPacket)
		{
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x002A2DD4 File Offset: 0x002A0FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ProcessMessage(Direction direction, ServerType serverType, IMessage message)
		{
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x002A2E78 File Offset: 0x002A1078
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ulong DecodeVarint(object buffer, ref int bytesRead)
		{
			return 0UL;
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x002A2E88 File Offset: 0x002A1088
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NetworkSniffer()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						NetworkSniffer.bufferMap = new Dictionary<string, List<byte>>();
						num2 = 2;
						break;
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						goto IL_B4;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						break;
					case 5:
						return;
					}
				}
				IL_B4:
				NetworkSniffer.connectionIPList = new List<string>
				{
					RggxEZnvRuJmA5QwCDl.XVInXhlssT(-888451311 - -549882920 ^ -1961215056 ^ <Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea, RggxEZnvRuJmA5QwCDl.SkGnoAmc9R),
					RggxEZnvRuJmA5QwCDl.XVInXhlssT(1367955064 ^ 1229914241 ^ <Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329, RggxEZnvRuJmA5QwCDl.SkGnoAmc9R),
					RggxEZnvRuJmA5QwCDl.XVInXhlssT(~1511057849 ^ -300336981 ^ <Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3, RggxEZnvRuJmA5QwCDl.SkGnoAmc9R)
				};
				num = 5;
			}
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x002A2FDC File Offset: 0x002A11DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JDIY1tJoXJTO7Lyg0Z04()
		{
			return true;
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x002A2FE4 File Offset: 0x002A11E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NetworkSniffer GaNJAVJoNf598mF3y7PP()
		{
			return null;
		}

		// Token: 0x04004215 RID: 16917
		private readonly SnifferForm snifferForm;

		// Token: 0x04004216 RID: 16918
		private Thread captureThread;

		// Token: 0x04004217 RID: 16919
		private bool isRunning;

		// Token: 0x04004218 RID: 16920
		private bool isPaused;

		// Token: 0x04004219 RID: 16921
		private int pid;

		// Token: 0x0400421A RID: 16922
		private FightManager fightManager;

		// Token: 0x0400421B RID: 16923
		private string NomPerso;

		// Token: 0x0400421C RID: 16924
		private static readonly Dictionary<string, List<byte>> bufferMap;

		// Token: 0x0400421D RID: 16925
		private static readonly List<string> connectionIPList;

		// Token: 0x0400421E RID: 16926
		private static NetworkSniffer NnlUNBJoE0aQFBorVQJe;
	}
}
