using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.House
{
	// Token: 0x02000531 RID: 1329
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildHouseRemoveEvent : IMessage<GuildHouseRemoveEvent>, IMessage, IEquatable<GuildHouseRemoveEvent>, IDeepCloneable<GuildHouseRemoveEvent>, IBufferMessage
	{
		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x001ED2B0 File Offset: 0x001EB4B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildHouseRemoveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x001ED2C0 File Offset: 0x001EB4C0
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

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x001ED2D0 File Offset: 0x001EB4D0
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

		// Token: 0x06003FCD RID: 16333 RVA: 0x001ED2E0 File Offset: 0x001EB4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildHouseRemoveEvent()
		{
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x001ED2F0 File Offset: 0x001EB4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildHouseRemoveEvent(GuildHouseRemoveEvent other)
		{
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x001ED300 File Offset: 0x001EB500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildHouseRemoveEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x001ED310 File Offset: 0x001EB510
		// (set) Token: 0x06003FD1 RID: 16337 RVA: 0x001ED320 File Offset: 0x001EB520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x001ED330 File Offset: 0x001EB530
		// (set) Token: 0x06003FD3 RID: 16339 RVA: 0x001ED340 File Offset: 0x001EB540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
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

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06003FD4 RID: 16340 RVA: 0x001ED350 File Offset: 0x001EB550
		// (set) Token: 0x06003FD5 RID: 16341 RVA: 0x001ED360 File Offset: 0x001EB560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SecondHand
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x001ED370 File Offset: 0x001EB570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x001ED380 File Offset: 0x001EB580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildHouseRemoveEvent other)
		{
			return true;
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x001ED390 File Offset: 0x001EB590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x001ED3A0 File Offset: 0x001EB5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x001ED3B0 File Offset: 0x001EB5B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x001ED3C0 File Offset: 0x001EB5C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x001ED3D0 File Offset: 0x001EB5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x001ED3E0 File Offset: 0x001EB5E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildHouseRemoveEvent other)
		{
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x001ED3F0 File Offset: 0x001EB5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x001ED400 File Offset: 0x001EB600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x001ED410 File Offset: 0x001EB610
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildHouseRemoveEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					GuildHouseRemoveEvent._parser = new MessageParser<GuildHouseRemoveEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x001ED4F4 File Offset: 0x001EB6F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XiRx4BOpEVT73hgnaHpE()
		{
			return true;
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x001ED4FC File Offset: 0x001EB6FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildHouseRemoveEvent zBjfN1OpXxMSa8HtpMsw()
		{
			return null;
		}

		// Token: 0x04001612 RID: 5650
		private static readonly MessageParser<GuildHouseRemoveEvent> _parser;

		// Token: 0x04001613 RID: 5651
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001614 RID: 5652
		public const int HouseIdFieldNumber = 1;

		// Token: 0x04001615 RID: 5653
		private int houseId_;

		// Token: 0x04001616 RID: 5654
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x04001617 RID: 5655
		private int instanceId_;

		// Token: 0x04001618 RID: 5656
		public const int SecondHandFieldNumber = 3;

		// Token: 0x04001619 RID: 5657
		private bool secondHand_;

		// Token: 0x0400161A RID: 5658
		private static GuildHouseRemoveEvent yCWq0vOp2SyleraZYTvL;
	}
}
