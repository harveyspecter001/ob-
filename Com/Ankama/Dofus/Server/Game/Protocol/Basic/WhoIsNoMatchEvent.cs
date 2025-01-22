using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BD2 RID: 3026
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WhoIsNoMatchEvent : IMessage<WhoIsNoMatchEvent>, IMessage, IEquatable<WhoIsNoMatchEvent>, IDeepCloneable<WhoIsNoMatchEvent>, IBufferMessage
	{
		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x060091B1 RID: 37297 RVA: 0x0026FFDC File Offset: 0x0026E1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WhoIsNoMatchEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x060091B2 RID: 37298 RVA: 0x0026FFEC File Offset: 0x0026E1EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x060091B3 RID: 37299 RVA: 0x0026FFFC File Offset: 0x0026E1FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x0027000C File Offset: 0x0026E20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsNoMatchEvent()
		{
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x0027001C File Offset: 0x0026E21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsNoMatchEvent(WhoIsNoMatchEvent other)
		{
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x0027002C File Offset: 0x0026E22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsNoMatchEvent Clone()
		{
			return null;
		}

		// Token: 0x060091B7 RID: 37303 RVA: 0x0027003C File Offset: 0x0026E23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060091B8 RID: 37304 RVA: 0x0027004C File Offset: 0x0026E24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(WhoIsNoMatchEvent other)
		{
			return true;
		}

		// Token: 0x060091B9 RID: 37305 RVA: 0x0027005C File Offset: 0x0026E25C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060091BA RID: 37306 RVA: 0x0027006C File Offset: 0x0026E26C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060091BB RID: 37307 RVA: 0x0027007C File Offset: 0x0026E27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x0027008C File Offset: 0x0026E28C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060091BD RID: 37309 RVA: 0x0027009C File Offset: 0x0026E29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060091BE RID: 37310 RVA: 0x002700AC File Offset: 0x0026E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(WhoIsNoMatchEvent other)
		{
		}

		// Token: 0x060091BF RID: 37311 RVA: 0x002700BC File Offset: 0x0026E2BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060091C0 RID: 37312 RVA: 0x002700CC File Offset: 0x0026E2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060091C1 RID: 37313 RVA: 0x002700DC File Offset: 0x0026E2DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static WhoIsNoMatchEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						WhoIsNoMatchEvent._parser = new MessageParser<WhoIsNoMatchEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						goto IL_36;
					}
				}
				IL_36:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x060091C2 RID: 37314 RVA: 0x002701AC File Offset: 0x0026E3AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mPvDHAJ2SBTOpgY4S6tU()
		{
			return true;
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x002701B4 File Offset: 0x0026E3B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WhoIsNoMatchEvent hKoicBJ2M5K1y2L1KUsO()
		{
			return null;
		}

		// Token: 0x04003649 RID: 13897
		private static readonly MessageParser<WhoIsNoMatchEvent> _parser;

		// Token: 0x0400364A RID: 13898
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400364B RID: 13899
		internal static WhoIsNoMatchEvent kRahBIJ2PHeXIiPNbJYa;
	}
}
