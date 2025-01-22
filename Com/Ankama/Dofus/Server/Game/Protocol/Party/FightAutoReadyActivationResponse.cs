using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002C4 RID: 708
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoReadyActivationResponse : IMessage<FightAutoReadyActivationResponse>, IMessage, IEquatable<FightAutoReadyActivationResponse>, IDeepCloneable<FightAutoReadyActivationResponse>, IBufferMessage
	{
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x001BA814 File Offset: 0x001B8A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightAutoReadyActivationResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x001BA824 File Offset: 0x001B8A24
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

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x001BA834 File Offset: 0x001B8A34
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

		// Token: 0x060020DD RID: 8413 RVA: 0x001BA844 File Offset: 0x001B8A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyActivationResponse()
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x001BA854 File Offset: 0x001B8A54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyActivationResponse(FightAutoReadyActivationResponse other)
		{
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x001BA864 File Offset: 0x001B8A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyActivationResponse Clone()
		{
			return null;
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x001BA874 File Offset: 0x001B8A74
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x001BA888 File Offset: 0x001B8A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightAutoReadyActivationResponse.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightAutoReadyActivationResponse.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x001BA898 File Offset: 0x001B8A98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x001BA8A8 File Offset: 0x001B8AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoReadyActivationResponse other)
		{
			return true;
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x001BA8B8 File Offset: 0x001B8AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x001BA8C8 File Offset: 0x001B8AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x001BA8D8 File Offset: 0x001B8AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x001BA8E8 File Offset: 0x001B8AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x001BA8F8 File Offset: 0x001B8AF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x001BA908 File Offset: 0x001B8B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoReadyActivationResponse other)
		{
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x001BA918 File Offset: 0x001B8B18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x001BA928 File Offset: 0x001B8B28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x001BA938 File Offset: 0x001B8B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoReadyActivationResponse()
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
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						break;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						return;
					case 4:
						goto IL_9C;
					}
				}
				IL_9C:
				FightAutoReadyActivationResponse._parser = new MessageParser<FightAutoReadyActivationResponse>(() => null);
				num = 3;
			}
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x001BAA08 File Offset: 0x001B8C08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sF6ZGuO653duNDH2ogku()
		{
			return true;
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x001BAA10 File Offset: 0x001B8C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoReadyActivationResponse qHJbqhO6yRa85dAfOXWl()
		{
			return null;
		}

		// Token: 0x04000B7F RID: 2943
		private static readonly MessageParser<FightAutoReadyActivationResponse> _parser;

		// Token: 0x04000B80 RID: 2944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B81 RID: 2945
		public const int ResultFieldNumber = 1;

		// Token: 0x04000B82 RID: 2946
		private FightAutoReadyActivationResponse.Types.Result result_;

		// Token: 0x04000B83 RID: 2947
		internal static FightAutoReadyActivationResponse kltOREO6a9FHaFMQmTwn;

		// Token: 0x020002C5 RID: 709
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060020EF RID: 8431 RVA: 0x002B4D44 File Offset: 0x002B2F44
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020002C6 RID: 710
			public enum Result
			{
				// Token: 0x04000B85 RID: 2949
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x04000B86 RID: 2950
				[OriginalName("ERROR")]
				Error
			}
		}
	}
}
