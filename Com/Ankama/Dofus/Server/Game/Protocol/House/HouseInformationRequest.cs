using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x0200044F RID: 1103
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseInformationRequest : IMessage<HouseInformationRequest>, IMessage, IEquatable<HouseInformationRequest>, IDeepCloneable<HouseInformationRequest>, IBufferMessage
	{
		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x001DABD0 File Offset: 0x001D8DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HouseInformationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x001DABE0 File Offset: 0x001D8DE0
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

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x0600346A RID: 13418 RVA: 0x001DABF0 File Offset: 0x001D8DF0
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

		// Token: 0x0600346B RID: 13419 RVA: 0x001DAC00 File Offset: 0x001D8E00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseInformationRequest()
		{
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x001DAC10 File Offset: 0x001D8E10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseInformationRequest(HouseInformationRequest other)
		{
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x001DAC20 File Offset: 0x001D8E20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseInformationRequest Clone()
		{
			return null;
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x001DAC30 File Offset: 0x001D8E30
		// (set) Token: 0x0600346F RID: 13423 RVA: 0x001DAC40 File Offset: 0x001D8E40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int HouseId
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

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x001DAC50 File Offset: 0x001D8E50
		// (set) Token: 0x06003471 RID: 13425 RVA: 0x001DAC60 File Offset: 0x001D8E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HouseInstanceId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x001DAC70 File Offset: 0x001D8E70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x001DAC80 File Offset: 0x001D8E80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseInformationRequest other)
		{
			return true;
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x001DAC90 File Offset: 0x001D8E90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x001DACA0 File Offset: 0x001D8EA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x001DACB0 File Offset: 0x001D8EB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x001DACC0 File Offset: 0x001D8EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x001DACD0 File Offset: 0x001D8ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x001DACE0 File Offset: 0x001D8EE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseInformationRequest other)
		{
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x001DACF0 File Offset: 0x001D8EF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x001DAD00 File Offset: 0x001D8F00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x001DAD10 File Offset: 0x001D8F10
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseInformationRequest()
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
						goto IL_35;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						HouseInformationRequest._parser = new MessageParser<HouseInformationRequest>(() => null);
						num2 = 4;
						break;
					case 4:
						return;
					}
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x001DADE0 File Offset: 0x001D8FE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TJ2boMODZuXQaXPcjVaX()
		{
			return true;
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x001DADE8 File Offset: 0x001D8FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseInformationRequest TkreYgODq6Z7S693hYdO()
		{
			return null;
		}

		// Token: 0x04001252 RID: 4690
		private static readonly MessageParser<HouseInformationRequest> _parser;

		// Token: 0x04001253 RID: 4691
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001254 RID: 4692
		public const int HouseIdFieldNumber = 1;

		// Token: 0x04001255 RID: 4693
		private int houseId_;

		// Token: 0x04001256 RID: 4694
		public const int HouseInstanceIdFieldNumber = 2;

		// Token: 0x04001257 RID: 4695
		private long houseInstanceId_;

		// Token: 0x04001258 RID: 4696
		internal static HouseInformationRequest TsFHUDOD8KOjvyXL8Mj5;
	}
}
