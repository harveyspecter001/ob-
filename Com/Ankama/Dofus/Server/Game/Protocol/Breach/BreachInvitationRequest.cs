using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000971 RID: 2417
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachInvitationRequest : IMessage<BreachInvitationRequest>, IMessage, IEquatable<BreachInvitationRequest>, IDeepCloneable<BreachInvitationRequest>, IBufferMessage
	{
		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06007503 RID: 29955 RVA: 0x002425B8 File Offset: 0x002407B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachInvitationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06007504 RID: 29956 RVA: 0x002425C8 File Offset: 0x002407C8
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

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06007505 RID: 29957 RVA: 0x002425D8 File Offset: 0x002407D8
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

		// Token: 0x06007506 RID: 29958 RVA: 0x002425E8 File Offset: 0x002407E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationRequest()
		{
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x002425F8 File Offset: 0x002407F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationRequest(BreachInvitationRequest other)
		{
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x00242608 File Offset: 0x00240808
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationRequest Clone()
		{
			return null;
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06007509 RID: 29961 RVA: 0x00242618 File Offset: 0x00240818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Guests
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600750A RID: 29962 RVA: 0x00242628 File Offset: 0x00240828
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x00242638 File Offset: 0x00240838
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachInvitationRequest other)
		{
			return true;
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x00242648 File Offset: 0x00240848
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x00242658 File Offset: 0x00240858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600750E RID: 29966 RVA: 0x00242668 File Offset: 0x00240868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600750F RID: 29967 RVA: 0x00242678 File Offset: 0x00240878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x00242688 File Offset: 0x00240888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x00242698 File Offset: 0x00240898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachInvitationRequest other)
		{
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x002426A8 File Offset: 0x002408A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x002426B8 File Offset: 0x002408B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x002426C8 File Offset: 0x002408C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachInvitationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					BreachInvitationRequest._repeated_guests_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(10U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					BreachInvitationRequest._parser = new MessageParser<BreachInvitationRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x002427E0 File Offset: 0x002409E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s2hRxvJRdvJhhM7vghDJ()
		{
			return true;
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x002427E8 File Offset: 0x002409E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachInvitationRequest WwUEv4JR9ZhEJGpRZoPc()
		{
			return null;
		}

		// Token: 0x040028C7 RID: 10439
		private static readonly MessageParser<BreachInvitationRequest> _parser;

		// Token: 0x040028C8 RID: 10440
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028C9 RID: 10441
		public const int GuestsFieldNumber = 1;

		// Token: 0x040028CA RID: 10442
		private static readonly FieldCodec<long> _repeated_guests_codec;

		// Token: 0x040028CB RID: 10443
		private readonly RepeatedField<long> guests_;

		// Token: 0x040028CC RID: 10444
		private static BreachInvitationRequest rakw0FJRshwNC08oouCy;
	}
}
