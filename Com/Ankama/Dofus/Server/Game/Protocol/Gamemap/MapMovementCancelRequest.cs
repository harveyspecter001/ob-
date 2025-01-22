using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000576 RID: 1398
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapMovementCancelRequest : IMessage<MapMovementCancelRequest>, IMessage, IEquatable<MapMovementCancelRequest>, IDeepCloneable<MapMovementCancelRequest>, IBufferMessage
	{
		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600434B RID: 17227 RVA: 0x001F4D7C File Offset: 0x001F2F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapMovementCancelRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x001F4D8C File Offset: 0x001F2F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x001F4DAC File Offset: 0x001F2FAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementCancelRequest()
		{
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x001F4DBC File Offset: 0x001F2FBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementCancelRequest(MapMovementCancelRequest other)
		{
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x001F4DCC File Offset: 0x001F2FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementCancelRequest Clone()
		{
			return null;
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x001F4DDC File Offset: 0x001F2FDC
		// (set) Token: 0x06004352 RID: 17234 RVA: 0x001F4DEC File Offset: 0x001F2FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CellId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x001F4DFC File Offset: 0x001F2FFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x001F4E0C File Offset: 0x001F300C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapMovementCancelRequest other)
		{
			return true;
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x001F4E1C File Offset: 0x001F301C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x001F4E2C File Offset: 0x001F302C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x001F4E3C File Offset: 0x001F303C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x001F4E4C File Offset: 0x001F304C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x001F4E5C File Offset: 0x001F305C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x001F4E6C File Offset: 0x001F306C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapMovementCancelRequest other)
		{
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x001F4E7C File Offset: 0x001F307C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x001F4E8C File Offset: 0x001F308C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x001F4E9C File Offset: 0x001F309C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapMovementCancelRequest()
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
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						MapMovementCancelRequest._parser = new MessageParser<MapMovementCancelRequest>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				IL_6E:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
				continue;
				goto IL_6E;
			}
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x001F4F84 File Offset: 0x001F3184
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rns8ahOHP1Zqmyten2cs()
		{
			return true;
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x001F4F8C File Offset: 0x001F318C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapMovementCancelRequest hWyALkOHStFmQ9ISHKvJ()
		{
			return null;
		}

		// Token: 0x04001735 RID: 5941
		private static readonly MessageParser<MapMovementCancelRequest> _parser;

		// Token: 0x04001736 RID: 5942
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001737 RID: 5943
		public const int CellIdFieldNumber = 1;

		// Token: 0x04001738 RID: 5944
		private int cellId_;

		// Token: 0x04001739 RID: 5945
		private static MapMovementCancelRequest ECDnr2OHicGdtvWSXwHf;
	}
}
