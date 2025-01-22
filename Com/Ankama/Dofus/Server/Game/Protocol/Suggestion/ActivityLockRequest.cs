using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Suggestion
{
	// Token: 0x0200010F RID: 271
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivityLockRequest : IMessage<ActivityLockRequest>, IMessage, IEquatable<ActivityLockRequest>, IDeepCloneable<ActivityLockRequest>, IBufferMessage
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x001973CC File Offset: 0x001955CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityLockRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x001973DC File Offset: 0x001955DC
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x001973EC File Offset: 0x001955EC
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

		// Token: 0x06000C61 RID: 3169 RVA: 0x001973FC File Offset: 0x001955FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivityLockRequest()
		{
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0019740C File Offset: 0x0019560C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivityLockRequest(ActivityLockRequest other)
		{
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0019741C File Offset: 0x0019561C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivityLockRequest Clone()
		{
			return null;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0019742C File Offset: 0x0019562C
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x0019743C File Offset: 0x0019563C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
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

		// Token: 0x06000C66 RID: 3174 RVA: 0x0019744C File Offset: 0x0019564C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0019745C File Offset: 0x0019565C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ActivityLockRequest other)
		{
			return true;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0019746C File Offset: 0x0019566C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0019747C File Offset: 0x0019567C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0019748C File Offset: 0x0019568C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0019749C File Offset: 0x0019569C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x001974AC File Offset: 0x001956AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x001974BC File Offset: 0x001956BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ActivityLockRequest other)
		{
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x001974CC File Offset: 0x001956CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x001974DC File Offset: 0x001956DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x001974EC File Offset: 0x001956EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ActivityLockRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ActivityLockRequest._parser = new MessageParser<ActivityLockRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x001975D0 File Offset: 0x001957D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GBKuqvOc3VmwD6aGHiGK()
		{
			return true;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x001975D8 File Offset: 0x001957D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ActivityLockRequest uSRAs3OcRVb7xjh0iMpP()
		{
			return null;
		}

		// Token: 0x0400047D RID: 1149
		private static readonly MessageParser<ActivityLockRequest> _parser;

		// Token: 0x0400047E RID: 1150
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400047F RID: 1151
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04000480 RID: 1152
		private int activityId_;

		// Token: 0x04000481 RID: 1153
		internal static ActivityLockRequest feWTWdOcecwvqB7ndwFX;
	}
}
